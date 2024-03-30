----------Linh trigger nhập hàng -------------
-- Tính tiền nhập hàng
drop trigger Tinh_TongTien_PhieuNhap
go
CREATE trigger Tinh_TongTien_PhieuNhap
    on CHITIET_PN
    for insert, update
    as
    begin
    	update 
    		PHIEUNHAP
    	set 
			TONGNHAP =(I.SL * I.GIANHAP) + TONGNHAP*1.0	
    	from 
    		inserted I,
			PHIEUNHAP PH,
    		CHITIET_PN CTPN
    	where 
    		(PH.MAPN = I.MAPN) 
    end
	GO
	---------------------- cập nhật tổng tiền khi xóa sp------------------------
	CREATE trigger Tinh_TongTien_PhieuNhap_Xoa
    on CHITIET_PN
    for delete
    as
    begin
    	update 
    		PHIEUNHAP
    	set 
			TONGNHAP = TONGNHAP - (I.SL * I.GIANHAP)
    	from 
    		deleted I,
			PHIEUNHAP PH,
    		CHITIET_PN CTPN
    	where 
    		(PH.MAPN = I.MAPN) 
    end
	go
--------------------------------------------
	---------------------Trigger cập nhật số lượng sp khi nhập hàng--------------
	CREATE TRIGGER trg_DatHang ON CHITIET_PN AFTER INSERT AS 
BEGIN
	UPDATE SANPHAM
	SET SOLUONG = SOLUONG + (
		SELECT SL
		FROM inserted
		WHERE MASP = SANPHAM.MASP
	)
	FROM SANPHAM
	JOIN inserted ON SANPHAM.MASP = inserted.MASP
END
GO
---------------------cập nhật số lượng khi xóa---------------------
drop trigger trg_DatHang_xoa
go
CREATE TRIGGER trg_DatHang_xoa ON CHITIET_PN AFTER DELETE AS 
BEGIN
	UPDATE SANPHAM
	SET SOLUONG = SOLUONG - (
		SELECT SL
		FROM deleted
		WHERE MASP = SANPHAM.MASP
	)
	FROM SANPHAM
	JOIN deleted ON SANPHAM.MASP = deleted.MASP
END
GO