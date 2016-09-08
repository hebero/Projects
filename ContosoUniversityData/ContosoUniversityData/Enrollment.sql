CREATE TABLE [dbo].[Enrollment]
(
	[EnrollmentId]	INT IDENTITY(1,1)	NOT NULL,
	[Grade]			DECIMAL(3,2)		NULL,
	[CourseId]		INT NOT NULL,
	[StudentId]		INT NOT NULL,
	PRIMARY KEY CLUSTERED([EnrollmentId] ASC),
	CONSTRAINT [FK_dbo.Enrollment_dbo.Course_CourseId] FOREIGN KEY ([CourseId])
		REFERENCES [dbo].[COURSE]([CourseId]) ON DELETE CASCADE,
	CONSTRAINT [FK_dbo.Enrollment_dbo.Student_StudentID] FOREIGN KEY ([StudentID]) 
        REFERENCES [dbo].[Student] ([StudentID]) ON DELETE CASCADE
)
