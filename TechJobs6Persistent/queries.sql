﻿-- Capture your answer here for each "Test It With SQL" section of this assignment
    -- write each as comments


--Part 1: List the columns and their data types in the Jobs table.

--Column names: Id, Name, EmployerId
--Respective Data Types: int, string, int

--Part 2: Write a query to list the names of the employers in St. Louis City.

-- SELECT Name
-- FROM employers
-- WHERE location="St.Louis";

--Part 3: Write a query to return a list of the names and descriptions of all skills that are attached to jobs in alphabetical order.
    --If a skill does not have a job listed, it should not be included in the results of this query.
    
    -- SELECT SkillName
    -- FROM skills
    -- INNER JOIN JobSkills ON Skills.Id=JobSkills.SkillsId
    -- INNER JOIN Jobs ON JobSkills.JobId=Job.Id
    -- ORDER BY Jobs.Name;
    

    

    