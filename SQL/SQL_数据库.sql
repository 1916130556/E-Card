CREATE DATABASE eeeeee
ON
(
    NAME=OneCartoon,
	FILENAME='E:\Vs-vs\E-Card\SQL\eeeeee_data.mdf',
	SIZE=5MB,
	MAXSIZE=20MB,
	FILEGROWTH=2MB
	)
LOG ON
(
    NAME=OneCartoon_log,
	FILENAME='E:\Vs-vs\E-Card\SQL\eeeeee_log.ldf',
	SIZE=2MB,
	MAXSIZE=10MB,
	FILEGROWTH=1MB
);

