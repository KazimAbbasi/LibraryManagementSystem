USE library;
GO

-- Remove all borrowing records.
DELETE FROM dbo.IRBook;

-- Remove all students.
DELETE FROM dbo.NewStudent;

-- Remove old login accounts, keeping username 1234.
DELETE FROM dbo.loginTable
WHERE username <> '1234';