﻿

CREATE TRIGGER capNhatSoLuongKhiThemHH ON CHITIET_HD AFTER INSERT AS 
BEGIN
	UPDATE SANPHAM
	SET SOLUONG = SOLUONG - (
		SELECT SL
		FROM inserted
		WHERE MASP = SANPHAM.MASP
	)
	FROM SANPHAM
	JOIN inserted ON SANPHAM.MASP = inserted.MASP
END


DROP TRIGGER capNhatSoLuongKhiThemHH 
SELECT * FROM SANPHAM WHERE TENSP=N'Lốc 4 hộp sữa tươi kem vanilla tự nhiên TH true MILK Top Kid Organic'
SELECT * FROM CHITIET_HD
SELECT * FROM HOADON
INSERT INTO CHITIET_HD VALUES(7,'1',3)