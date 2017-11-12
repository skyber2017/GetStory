USE hocsinh
GO
CREATE TABLE hocsinh
(
	_maso INT,
	_holot NVARCHAR(100),
	_ten NVARCHAR(100),
	_ngaysinh DATETIME,
	_gioitinh BIT,
	_hinhanh image
)
GO
INSERT INTO hocsinh(_maso,_holot,_ten,_ngaysinh,_gioitinh)
VALUES('1','Nguyen','Duy','03/08/1997','1')
GO


