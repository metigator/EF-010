### Metigator Academy  :school:
Database for an Academy that provide trainings

``` sql
Create Database MetigatorAcademy;
Go
Use MetigatorAcademy;
```

##### + Courses  :book:
<div style="padding: 10px; font-size: 10px; font-weight: bold">

| Id | Course Name    | Price |
|----|----------------|------|
| 1  | Mathematics    |$1000.00|
| 2  | Physics        |$2000.00|
| 3  | Chemistry      |$1500.00|
| 4  | Biology        |$1200.00|
| 5  | Computer Science |$3000.00|

</div>

``` sql

-- Courses Table
CREATE TABLE Courses (
    Id INT PRIMARY KEY,
    CourseName VARCHAR(255) NOT NULL,
    Price DECIMAL(15, 2) NOT NULL
);

    -- Inserting data for Courses
    INSERT INTO Courses (Id, CourseName, Price) VALUES (1, 'Mathematics', 1000.00);
    INSERT INTO Courses (Id, CourseName, Price) VALUES (2, 'Physics', 2000.00);
    INSERT INTO Courses (Id, CourseName, Price) VALUES (3, 'Chemistry', 1500.00);
    INSERT INTO Courses (Id, CourseName, Price) VALUES (4, 'Biology', 1200.00);
    INSERT INTO Courses (Id, CourseName, Price) VALUES (5, 'Computer Science', 3000.00);

```

##### + Office  :book:
<div style="padding: 10px; font-size: 10px; font-weight: bold">

| Id | Office Name    | Location |
|----|----------------|----------|
| 1  | Off_05    |Building A|
| 2  | Off_12        |building B|
| 3  | Off_32      |Adminstration|
| 4  | Off_44        |IT Department|
| 5  |Off_43 |IT Department|

</div>

``` sql

-- Courses Table
CREATE TABLE Offices (
    Id INT PRIMARY KEY,
    OfficeName VARCHAR(50) NOT NULL,
    OfficeLocation VARCHAR(50) NOT NULL
);

    -- Inserting data for Offices
    INSERT INTO Courses (Id, OfficeName, OfficeLocation) VALUES (1, 'Off_05', building A);
    INSERT INTO Courses (Id, CourseName, OfficeLocation) VALUES (2, 'Off_12', building B);
    INSERT INTO Courses (Id, CourseName, OfficeLocation) VALUES (3, 'Off_32', Adminstration);
    INSERT INTO Courses (Id, CourseName, OfficeLocation) VALUES (4, 'Off_44', IT Department);
    INSERT INTO Courses (Id, CourseName, OfficeLocation) VALUES (5, 'Off_43', IT Department);

```

##### + Instructors Table :mens:

<div style="padding: 10px; font-size: 10px; font-weight: bold">

| Id | Name             | Location |
|----|------------------|----------|
| 1  | Ahmed Abdullah  | Off_05|
| 2  | Yasmeen Mohammed |Off_12|
| 3  | Khalid Hassan   |Off_32|
| 4  | Nadia Ali       |Off_44|
| 5  | Omar Ibrahim    |Off_43|
</div>

``` sql

-- Instructors Table
CREATE TABLE Instructors (
    Id INT PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    OfficeId INT NOT NULL REFERENCES Offices(Id),
);

    -- Inserting data for Instructors
    INSERT INTO Instructors (Id, Name, OfficeId) VALUES (1, 'Ahmed Abdullah', 1);
    INSERT INTO Instructors (Id, Name, OfficeId) VALUES (2, 'Yasmeen Mohammed', 2);
    INSERT INTO Instructors (Id, Name, OfficeId) VALUES (3, 'Khalid Hassan', 3);
    INSERT INTO Instructors (Id, Name, OfficeId) VALUES (4, 'Nadia Ali', 4);
    INSERT INTO Instructors (Id, Name, OfficeId) VALUES (5, 'Omar Ibrahim', 5);

```

##### + Sections Table :department_store:

<div style="padding: 10px; font-size: 10px; font-weight: bold">

| Id | Course Name    | Section Name   | Instructor Name  | ScheduleTitle | Start Time | End Time | SUN | MON | TUE | WED | THU | FRI | SAT |
|----|----------------|----------------|------------------|---------------|------------|----------|-----|-----|-----|-----|-----|-----|-----|
| 1  | Mathematics    |    S_MA1       | Ahmed Abdullah   |  DayAfterDay  | 10:00:00   | 12:00:00 |  :heavy_check_mark:  |  :heavy_check_mark: |  :heavy_check_mark:  |  :heavy_check_mark:  |:heavy_check_mark:  |    |    |
| 2  | Mathematics    |    S_MA2       | Yasmeen Mohammed |  Twice-a-Week | 14:00:00   | 16:00:00 |    |  :heavy_check_mark:  |    |  :heavy_check_mark:  |    |    |    |
| 3  | Physics        |    S_PH1       | Ahmed Abdullah   |  Weekend      | 16:00:00   | 18:00:00 |    |    |    |    |    |  :heavy_check_mark:  |  :heavy_check_mark:  |
| 4  | Physics        |    S_PH2       | Khalid Hassan    |  Daily        | 08:00:00   | 10:00:00 |  :heavy_check_mark:  |  :heavy_check_mark:  |  :heavy_check_mark:  |  :heavy_check_mark:  |  :heavy_check_mark:  |    |    |
| 5  | Chemistry      |    S_CH1       | Yasmeen Mohammed |  Daily        | 10:00:00   | 12:00:00 |  :heavy_check_mark:  |  :heavy_check_mark:  |  :heavy_check_mark:  |  :heavy_check_mark:  |  :heavy_check_mark:  |    |    |
| 6  | Chemistry      |    S_CH2       | Khalid Hassan    |  DayAfterDay  | 14:00:00   | 16:00:00 |  :heavy_check_mark:  |    |  :heavy_check_mark:  |    |  :heavy_check_mark:  |    |    |
| 7  | Biology        |    S_BI1       | Nadia Ali        |  Twice-a-Week | 16:00:00   | 18:00:00 |    |  :heavy_check_mark:  |    |  :heavy_check_mark:  |    |    |    |
| 8  | Biology        |    S_BI2       | Omar Ibrahim     |  Weekend      | 08:00:00   | 10:00:00 |    |    |    |    |    |  :heavy_check_mark:  |  :heavy_check_mark:  |
| 9  | CS50           |    S_CS1       | Nadia Ali        |  Weekend      | 10:00:00   | 15:00:00 |    |    |    |    |    |  :heavy_check_mark:  |  :heavy_check_mark:  |
| 10 | CS50           |    S_CS2       | Omar Ibrahim     |  Twice-a-Week | 14:00:00   | 16:00:00 |    |  :heavy_check_mark:  |    |  :heavy_check_mark:  |    |    |    |
| 11 | CS50           |    S_CS3       | Nadia Ali     |  Compact | 09:00:00   | 11:00:00 |  :heavy_check_mark:   |  :heavy_check_mark:  | :heavy_check_mark:    |  :heavy_check_mark:  |  :heavy_check_mark:   |  :heavy_check_mark:   |  :heavy_check_mark:   |
</div>

``` sql

-- sections table
CREATE TABLE Sections (
    Id INT PRIMARY KEY,
    SectionName VARCHAR(50) NOT NULL,
    CourseId INT,
    InstructorId INT,
    FOREIGN KEY (CourseId) REFERENCES Courses(Id),
    FOREIGN KEY (InstructorId) REFERENCES Instructors(Id)
);

    -- indexes
    CREATE INDEX idx_sections_course_id ON Sections (CourseId);
    CREATE INDEX idx_sections_instructor_id ON Sections (InstructorId);

    INSERT INTO Sections (Id, SectionName, CourseId, InstructorId) VALUES (1, 'S_MA1', 1, 1);
    INSERT INTO Sections (Id, SectionName, CourseId, InstructorId) VALUES (2, 'S_MA2', 1, 2);
    INSERT INTO Sections (Id, SectionName, CourseId, InstructorId) VALUES (3, 'S_PH1', 2, 1);
    INSERT INTO Sections (Id, SectionName, CourseId, InstructorId) VALUES (4, 'S_PH2', 2, 3);
    INSERT INTO Sections (Id, SectionName, CourseId, InstructorId) VALUES (5, 'S_CH1', 3, 2);
    INSERT INTO Sections (Id, SectionName, CourseId, InstructorId) VALUES (6, 'S_CH2', 3, 3);
    INSERT INTO Sections (Id, SectionName, CourseId, InstructorId) VALUES (7, 'S_BI1', 4, 4);
    INSERT INTO Sections (Id, SectionName, CourseId, InstructorId) VALUES (8, 'S_BI2', 4, 5);
    INSERT INTO Sections (Id, SectionName, CourseId, InstructorId) VALUES (9, 'S_CS1', 5, 4);
    INSERT INTO Sections (Id, SectionName, CourseId, InstructorId) VALUES (10,'S_CS2', 5, 5);
    INSERT INTO Sections (Id, SectionName, CourseId, InstructorId) VALUES (11,'S_CS3', 5, 4);

-- Schedules Table
CREATE TABLE Schedules
(
    Id INT PRIMARY KEY,
    Title VARCHAR(100) NOT NULL,
    SUN BIT NOT NULL,
    MON BIT NOT NULL,
    TUE BIT NOT NULL,
    WED BIT NOT NULL,
    THU BIT NOT NULL,
    FRI BIT NOT NULL,
    SAT BIT NOT NULL
);

    -- Inserting data for Schedules
    INSERT INTO Schedules (Id, Title, SUN, MON, TUE, WED, THU, FRI, SAT) VALUES (1, 'Daily', 1, 1, 1, 1, 1, 0, 0);
    INSERT INTO Schedules (Id, Title, SUN, MON, TUE, WED, THU, FRI, SAT) VALUES (2, 'DayAfterDay', 1, 0, 1, 0, 1, 0, 0);
    INSERT INTO Schedules (Id, Title, SUN, MON, TUE, WED, THU, FRI, SAT) VALUES (3, 'Twice-a-Week', 0, 1, 0, 1, 0, 0, 0);
    INSERT INTO Schedules (Id, Title, SUN, MON, TUE, WED, THU, FRI, SAT) VALUES (4, 'Weekend', 0, 0, 0, 0, 0, 1, 1);
    INSERT INTO Schedules (Id, Title, SUN, MON, TUE, WED, THU, FRI, SAT) VALUES (5, 'Compact', 1, 1, 1, 1, 1, 1, 1);


-- SectionSchedules Table
CREATE TABLE SectionSchedules (
    Id INT PRIMARY KEY,
    SectionId INT NOT NULL,
    ScheduleId INT NOT NULL,
    StartTime TIME NOT NULL,
    EndTime TIME NOT NULL, 
    FOREIGN KEY (SectionId) REFERENCES Sections(Id),
    FOREIGN KEY (ScheduleId) REFERENCES Schedules(Id)
);

    -- indexes
    CREATE INDEX idx_section_schedules_schedule_id ON SectionSchedules (ScheduleId);

    -- Inserting data for SectionSchedules
    INSERT INTO SectionSchedules (Id, SectionId, ScheduleId, StartTime, EndTime) VALUES (1, 1, 1, '08:00:00', '10:00:00');
    INSERT INTO SectionSchedules (Id, SectionId, ScheduleId, StartTime, EndTime) VALUES (2, 2, 3, '14:00:00', '18:00:00');
    INSERT INTO SectionSchedules (Id, SectionId, ScheduleId, StartTime, EndTime) VALUES (3, 3, 4, '10:00:00', '15:00:00');
    INSERT INTO SectionSchedules (Id, SectionId, ScheduleId, StartTime, EndTime) VALUES (4, 4, 1, '10:00:00', '12:00:00');
    INSERT INTO SectionSchedules (Id, SectionId, ScheduleId, StartTime, EndTime) VALUES (5, 5, 1, '16:00:00', '18:00:00');
    INSERT INTO SectionSchedules (Id, SectionId, ScheduleId, StartTime, EndTime) VALUES (6, 6, 2, '08:00:00', '10:00:00');
    INSERT INTO SectionSchedules (Id, SectionId, ScheduleId, StartTime, EndTime) VALUES (7, 7, 3, '11:00:00', '14:00:00');
    INSERT INTO SectionSchedules (Id, SectionId, ScheduleId, StartTime, EndTime) VALUES (8, 8, 4, '10:00:00', '14:00:00');
    INSERT INTO SectionSchedules (Id, SectionId, ScheduleId, StartTime, EndTime) VALUES (9, 9, 4, '16:00:00', '18:00:00');
    INSERT INTO SectionSchedules (Id, SectionId, ScheduleId, StartTime, EndTime) VALUES (10, 10, 3, '12:00:00', '15:00:00');
    INSERT INTO SectionSchedules (Id, SectionId, ScheduleId, StartTime, EndTime) VALUES (11, 11, 5, '09:00:00', '11:00:00');
```

#### + Student Enrollment :man: :girl:

<div style="padding: 10px; font-size: 10px; font-weight: bold">

| Section Name | Student Name   |
|--------------|----------------|
| S_MA2        | Fatima Ali     |
| S_MA2        | Noor Saleh     |
| S_PH1        | Omar Youssef   |
| S_PH1        | Huda Ahmed     |
| S_PH2        | Amira Tariq    |
| S_PH2        | Zainab Ismail  |
| S_BI1        | Yousef Farid   |
| S_BI1        | Layla Mustafa  |
| S_CS1        | Mohammed Adel  |
| S_CS2        | Samira Nabil   |

</div>

``` sql

-- Students Table
CREATE TABLE Students (
    Id INT PRIMARY KEY,
    Name VARCHAR(255) NOT NULL,
);

    -- Inserting data for Students
    INSERT INTO Students (Id, Name) VALUES (1, 'Fatima Ali');
    INSERT INTO Students (Id, Name) VALUES (2, 'Noor Saleh');
    INSERT INTO Students (Id, Name) VALUES (3, 'Omar Youssef');
    INSERT INTO Students (Id, Name) VALUES (4, 'Huda Ahmed');
    INSERT INTO Students (Id, Name) VALUES (5, 'Amira Tariq');
    INSERT INTO Students (Id, Name) VALUES (6, 'Zainab Ismail');
    INSERT INTO Students (Id, Name) VALUES (7, 'Yousef Farid');
    INSERT INTO Students (Id, Name) VALUES (8, 'Layla Mustafa');
    INSERT INTO Students (Id, Name) VALUES (9, 'Mohammed Adel');
    INSERT INTO Students (Id, Name) VALUES (10, 'Samira Nabil');


-- Enrollments Table
CREATE TABLE Enrollments (
    StudentId INT,
    SectionId INT,
    PRIMARY KEY (StudentId, SectionId),
    FOREIGN KEY (StudentId) REFERENCES Students(Id),
    FOREIGN KEY (SectionId) REFERENCES Sections(Id)
);


    -- indexes
    CREATE INDEX idx_enrollments_section_id ON Enrollments (SectionId);

    -- Inserting data for Enrollments
    INSERT INTO Enrollments (StudentId, SectionId) VALUES (1, 6);
    INSERT INTO Enrollments (StudentId, SectionId) VALUES (2, 6);
    INSERT INTO Enrollments (StudentId, SectionId) VALUES (3, 7);
    INSERT INTO Enrollments (StudentId, SectionId) VALUES (4, 7);
    INSERT INTO Enrollments (StudentId, SectionId) VALUES (5, 8);
    INSERT INTO Enrollments (StudentId, SectionId) VALUES (6, 8);
    INSERT INTO Enrollments (StudentId, SectionId) VALUES (7, 9);
    INSERT INTO Enrollments (StudentId, SectionId) VALUES (8, 9);
    INSERT INTO Enrollments (StudentId, SectionId) VALUES (9, 10);
    INSERT INTO Enrollments (StudentId, SectionId) VALUES (10, 10);

```
