using DB_Final.BL;
using DB_Final.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace DB_Final
{
    public class DatabaseScripts
    {
        public static string GetSocietyMemberCount = @" SELECT s.id, s.name, COUNT(m.id) AS MemberCount FROM society s LEFT JOIN membership m ON s.id = m.societyId GROUP BY s.id, s.name";
        // EVENT CATEGORY
        public static string GetAllEventCategories = "SELECT * FROM EventCategory";
        public static string GetEventCategoryById = "SELECT * FROM EventCategory WHERE id = @id";
        public static string InsertEventCategory = "INSERT INTO EventCategory (name, description) VALUES (@name, @description)";
        public static string UpdateEventCategory = "UPDATE EventCategory SET name = @name, description = @description WHERE id = @id";
        public static string DeleteEventCategory = "DELETE FROM EventCategory WHERE id = @id";

        // SOCIETY CATEGORY
        public static string GetAllSocietyCategories = "SELECT * FROM SocietyCategory";
        public static string GetSocietyCategoryById = "SELECT * FROM SocietyCategory WHERE id = @id";
        public static string InsertSocietyCategory = "INSERT INTO SocietyCategory (name, description) VALUES (@name, @description)";
        public static string UpdateSocietyCategory = "UPDATE SocietyCategory SET name = @name, description = @description WHERE id = @id";
        public static string DeleteSocietyCategory = "DELETE FROM SocietyCategory WHERE id = @id";

        // SPONSOR
        public static string GetAllSponsors = "SELECT * FROM Sponsor";
        public static string GetSponsorById = "SELECT * FROM Sponsor WHERE id = @id";
        public static string InsertSponsor = "INSERT INTO Sponsor (name, organization, email, phone) VALUES (@name, @organization, @email, @phone)";
        public static string UpdateSponsor = "UPDATE Sponsor SET name = @name, organization = @organization, email = @email, phone = @phone WHERE id = @id";
        public static string DeleteSponsor = "DELETE FROM Sponsor WHERE id = @id";

        // STUDENT
        public static string GetAllStudents = "SELECT * FROM Student";
        public static string GetStudentById = "SELECT * FROM Student WHERE id = @id";
        public static string InsertStudent = "INSERT INTO Student (name, email, department, phone, batchYear, regNo, status) VALUES (@name, @email, @department, @phone, @batchYear, @regNo, @status)";
        public static string UpdateStudent = "UPDATE Student SET name = @name, email = @email, department = @department, phone = @phone, batchYear = @batchYear, regNo = @regNo, status = @status WHERE id = @id";
        public static string DeleteStudent = "DELETE FROM Student WHERE id = @id";

        // VENUE
        public static string GetAllVenues = "SELECT * FROM Venue";
        public static string GetVenueById = "SELECT * FROM Venue WHERE id = @id";
        public static string InsertVenue = "INSERT INTO Venue (name, location, capacity, facilities) VALUES (@name, @location, @capacity, @facilities)";
        public static string UpdateVenue = "UPDATE Venue SET name = @name, location = @location, capacity = @capacity, facilities = @facilities WHERE id = @id";
        public static string DeleteVenue = "DELETE FROM Venue WHERE id = @id";

        // ROLES
        public static string GetAllRoles = "SELECT * FROM roles";
        public static string GetRoleById = "SELECT name FROM roles WHERE id = @id";
        public static string InsertRole = "INSERT INTO roles (name, description) VALUES (@name, @description)";
        public static string UpdateRole = "UPDATE roles SET name = @name, description = @description WHERE id = @id";
        public static string DeleteRole = "DELETE FROM roles WHERE id = @id";

        // SOCIETY 
        public static string GetAllSocieties = @"SELECT s.id,s.name,s.status, s.foundedDate,s.description,s.logoPath,
        sc.id AS categoryId,sc.name AS categoryName FROM Society s LEFT JOIN SocietyCategory sc ON s.categoryId = sc.id";

        public static string GetSocietyById = @"
            SELECT s.id, s.name, s.status, s.foundedDate, s.description,
                   sc.id AS categoryId, sc.name AS categoryName
            FROM Society s
            LEFT JOIN SocietyCategory sc ON s.categoryId = sc.id
            WHERE s.id = @id";

        public static string InsertSociety ="INSERT INTO Society " + "(name, status, foundedDate, description, categoryId, logoPath) " +
        "VALUES (@name, @status, @foundedDate, @description, @categoryId, @logoPath)";
        public static string DeleteSociety = "DELETE FROM Society WHERE id = @id";
        public static string UpdateSociety ="UPDATE Society SET name=@name, status=@status, foundedDate=@foundedDate, " +
        "description=@description, categoryId=@categoryId, logoPath=@logoPath WHERE id=@id";

        public static string GetAllAnnouncements = @"
    SELECT a.id,
           a.title,
           a.message,
           a.postedAt,
           a.societyId,
           s.name AS societyName
    FROM Announcement a
    LEFT JOIN Society s ON a.societyId = s.id";

        public static string GetAnnouncementById = @"
            SELECT a.id, a.title, a.message, a.postedAt,
                   s.name AS societyName
            FROM Announcement a
            LEFT JOIN Society s ON a.societyId = s.id
            WHERE a.id = @id";

        public static string InsertAnnouncement = "INSERT INTO Announcement (title, message, postedAt, societyId) VALUES (@title, @message, @postedAt, @societyId)";
        public static string UpdateAnnouncement = "UPDATE Announcement SET title = @title, message = @message, societyId = @societyId WHERE id = @id";
        public static string DeleteAnnouncement = "DELETE FROM Announcement WHERE id = @id";

        // EVENT 
        public static string GetAllEvents = @" SELECT  e.id, e.title, e.status, e.capacity, e.eventDatetime, e.description, e.societyId, e.venueId, e.categoryId,
        s.name AS societyName, v.name AS venueName, ec.name AS categoryName FROM Event e LEFT JOIN Society s ON e.societyId = s.id
         LEFT JOIN Venue v ON e.venueId = v.id LEFT JOIN EventCategory ec ON e.categoryId = ec.id";

        public static string GetEventById = @"
    SELECT e.id,
           e.title,
           e.status,
           e.capacity,
           e.eventDatetime,
           e.description,
           e.societyId,
           e.venueId,
           e.categoryId
    FROM Event e
    WHERE e.id = @id";

        public static string InsertEvent = "INSERT INTO Event (status, description, capacity, title, eventDatetime, societyId, venueId, categoryId) VALUES (@status, @description, @capacity, @title, @eventDatetime, @societyId, @venueId, @categoryId)";
        public static string UpdateEvent = "UPDATE Event SET status = @status, description = @description, capacity = @capacity, title = @title, eventDatetime = @eventDatetime, societyId = @societyId, venueId = @venueId, categoryId = @categoryId WHERE id = @id";
        public static string DeleteEvent = "DELETE FROM Event WHERE id = @id";

        // EVENT REGISTRATION 
        public static string GetAllEventRegistrations = @"
        SELECT er.id,
       er.registrationDate,
       er.status,
       er.cancellationDate,
       er.cancellationReason,
       er.studentId,
       er.eventId
FROM EventRegistration er";

        public static string GetEventRegistrationById = @"
            SELECT er.id, er.registrationDate, er.status, er.cancellationDate, er.cancellationReason,
                   s.name AS studentName, s.regNo AS studentRegNo,
                   e.title AS eventTitle
            FROM EventRegistration er
            LEFT JOIN Student s ON er.studentId = s.id
            LEFT JOIN Event e ON er.eventId = e.id
            WHERE er.id = @id";

        public static string InsertEventRegistration = "INSERT INTO EventRegistration (registrationDate, status, cancellationDate, cancellationReason, studentId, eventId) VALUES (@registrationDate, @status, @cancellationDate, @cancellationReason, @studentId, @eventId)";
        public static string UpdateEventRegistration = "UPDATE EventRegistration SET registrationDate = @registrationDate, status = @status, cancellationDate = @cancellationDate, cancellationReason = @cancellationReason, studentId = @studentId, eventId = @eventId WHERE id = @id";
        public static string DeleteEventRegistration = "DELETE FROM EventRegistration WHERE id = @id";

        // MEMBERSHIP 
        public static string GetAllMemberships = @"
SELECT 
    m.id,
    m.status,
    m.joinDate,
    m.leaveDate,
    m.studentId,
    m.societyId,
    s.name AS studentName,
    so.name AS societyName
FROM Membership m
LEFT JOIN Student s ON m.studentId = s.id
LEFT JOIN Society so ON m.societyId = so.id";

        public static string GetMembershipById = @"
SELECT 
    m.id,
    m.status,
    m.joinDate,
    m.leaveDate,
    m.studentId,
    m.societyId,
    s.name AS studentName,
    s.regNo AS studentRegNo,
    so.name AS societyName
FROM Membership m
LEFT JOIN Student s ON m.studentId = s.id
LEFT JOIN Society so ON m.societyId = so.id
WHERE m.id = @id";

        public static string InsertMembership = "INSERT INTO Membership (status, joinDate, leaveDate, studentId, societyId) VALUES (@status, @joinDate, @leaveDate, @studentId, @societyId)";
        public static string UpdateMembership = "UPDATE Membership SET status = @status, joinDate = @joinDate, leaveDate = @leaveDate, studentId = @studentId, societyId = @societyId WHERE id = @id";
        public static string DeleteMembership = "DELETE FROM Membership WHERE id = @id";

        // MEMBERSHIP ROLE HISTORY 
        public static string GetAllMembershipRoleHistories = @"
            SELECT mrh.id, mrh.startDate, mrh.endDate,
                   r.name AS roleName,
                   s.name AS studentName, s.regNo AS studentRegNo,
                   so.name AS societyName
            FROM MembershipRoleHistory mrh
            LEFT JOIN roles r ON mrh.roleId = r.id
            LEFT JOIN Membership m ON mrh.membershipId = m.id
            LEFT JOIN Student s ON m.studentId = s.id
            LEFT JOIN Society so ON m.societyId = so.id";

        public static string GetMembershipRoleHistoryById = @"
            SELECT mrh.id, mrh.startDate, mrh.endDate,
                   r.name AS roleName,
                   s.name AS studentName, s.regNo AS studentRegNo,
                   so.name AS societyName
            FROM MembershipRoleHistory mrh
            LEFT JOIN roles r ON mrh.roleId = r.id
            LEFT JOIN Membership m ON mrh.membershipId = m.id
            LEFT JOIN Student s ON m.studentId = s.id
            LEFT JOIN Society so ON m.societyId = so.id
            WHERE mrh.id = @id";

        public static string InsertMembershipRoleHistory = "INSERT INTO MembershipRoleHistory (startDate, endDate, roleId, membershipId) VALUES (@startDate, @endDate, @roleId, @membershipId)";
        public static string UpdateMembershipRoleHistory = "UPDATE MembershipRoleHistory SET startDate = @startDate, endDate = @endDate, roleId = @roleId, membershipId = @membershipId WHERE id = @id";
        public static string DeleteMembershipRoleHistory = "DELETE FROM MembershipRoleHistory WHERE id = @id";

        // FEEDBACK 
        public static string GetAllFeedbacks = @"
SELECT
    f.id,
    f.rating,
    f.comment,
    f.submittedAt,
    f.studentId,
    f.eventId,
    s.name AS studentName,
    s.regNo AS studentRegNo,
    e.title AS eventTitle
FROM Feedback f
LEFT JOIN Student s ON f.studentId = s.id
LEFT JOIN Event e ON f.eventId = e.id";

        public static string GetAllFeedback = @"
 SELECT f.id, f.rating, f.comment, f.submittedAt, f.studentId, f.eventId,
       s.name AS studentName, e.title AS eventTitle
FROM Feedback f
LEFT JOIN Student s ON f.studentId = s.id
LEFT JOIN Event e ON f.eventId = e.id";

        public static string GetFeedbackById = @"
            SELECT f.id, f.rating, f.comment, f.submittedAt,
                   s.name AS studentName, s.regNo AS studentRegNo,
                   e.title AS eventTitle
            FROM Feedback f
            LEFT JOIN Student s ON f.studentId = s.id
            LEFT JOIN Event e ON f.eventId = e.id
            WHERE f.id = @id";

        public static string InsertFeedback = "INSERT INTO Feedback (rating, comment, submittedAt, eventId, studentId) VALUES (@rating, @comment, @submittedAt, @eventId, @studentId)";
        public static string UpdateFeedback = "UPDATE Feedback SET rating = @rating, comment = @comment, submittedAt = @submittedAt, eventId = @eventId, studentId = @studentId WHERE id = @id";
        public static string DeleteFeedback = "DELETE FROM Feedback WHERE id = @id";

        // SPONSORSHIP 
        public static string GetAllSponsorships = @"SELECT sp.id, sp.amount, sp.sponsorshipDate,
       sp.sponsorId, sp.eventId FROM Sponsorship sp";

        public static string GetSponsorshipById = @"SELECT sp.id, sp.amount, sp.sponsorshipDate,
       sp.sponsorId, sp.eventId FROM Sponsorship sp WHERE sp.id = @id";
        public static string InsertSponsorship = "INSERT INTO Sponsorship (amount, sponsorshipDate, sponsorId, eventId) VALUES (@amount, @sponsorshipDate, @sponsorId, @eventId)";
        public static string UpdateSponsorship = "UPDATE Sponsorship SET amount = @amount, sponsorshipDate = @sponsorshipDate, sponsorId = @sponsorId, eventId = @eventId WHERE id = @id";
        public static string DeleteSponsorship = "DELETE FROM Sponsorship WHERE id = @id";



        // REPORT QUERIES
        // Button 1 — All Events (From/To date filter)
        public static string EventsReport = @"
    SELECT e.title, s.name AS societyName, v.name AS venueName,
           ec.name AS categoryName, e.eventDatetime, e.capacity, e.status
    FROM Event e
    JOIN Society s ON s.id = e.societyId
    JOIN EventCategory ec ON ec.id = e.categoryId
    JOIN Venue v ON v.id = e.venueId
    WHERE (@fromDate IS NULL OR e.eventDatetime >= @fromDate)
      AND (@toDate   IS NULL OR e.eventDatetime <= @toDate)";

        // Button 2 — Event Registrations (status filter)
        public static string RptEventRegistrations = @"
    SELECT er.registrationDate, er.status, er.cancellationReason,
           s.name AS studentName, s.regNo,
           e.title AS eventTitle
    FROM EventRegistration er
    LEFT JOIN Student s ON er.studentId = s.id
    LEFT JOIN Event e   ON er.eventId   = e.id
    WHERE (@status IS NULL OR er.status = @status)";

        // Button 3 — Society Members (society name + status filter)
        public static string RptSocietyMembers = @"
    SELECT s.name AS studentName, s.regNo, s.department,
           m.joinDate, m.leaveDate, m.status,
           so.name AS societyName
    FROM Membership m
    LEFT JOIN Student s  ON m.studentId  = s.id
    LEFT JOIN Society so ON m.societyId  = so.id
    WHERE (@societyName IS NULL OR so.name = @societyName)
      AND (@status      IS NULL OR m.status = @status)";

        // Button 4 — Students (department filter)
        public static string RptStudents = @"
    SELECT name, regNo, email, phone, department, batchYear, status
    FROM Student
    WHERE (@department IS NULL OR department = @department)
      AND (@batchYear  IS NULL OR batchYear  = @batchYear)";

        // Button 5 — Sponsorships (date range filter)
        public static string RptSponsorships = @"
    SELECT sp.amount, sp.sponsorshipDate,
           s.name AS sponsorName, s.organization,
           e.title AS eventTitle
    FROM Sponsorship sp
    LEFT JOIN Sponsor s ON sp.sponsorId = s.id
    LEFT JOIN Event e   ON sp.eventId   = e.id
    WHERE (@fromDate IS NULL OR sp.sponsorshipDate >= @fromDate)
      AND (@toDate   IS NULL OR sp.sponsorshipDate <= @toDate)";

        // Button 6 — Total Sponsorship by Event (no filter)
        public static string RptTotalSponsorshipByEvent = @"
    SELECT e.title AS eventTitle, so.name AS societyName,
           COUNT(sp.id)    AS totalSponsors,
           SUM(sp.amount)  AS totalAmount
    FROM Sponsorship sp
    LEFT JOIN Event e   ON sp.eventId   = e.id
    LEFT JOIN Society so ON e.societyId = so.id
    GROUP BY e.id, e.title, so.name";

        // Button 7 — Venue Utilization (venue name filter)
        public static string RptVenueUtilization = @"
    SELECT v.name AS venueName, v.location, v.capacity AS venueCapacity,
           e.title AS eventTitle, e.eventDatetime, e.status
    FROM Event e
    LEFT JOIN Venue v ON e.venueId = v.id
    WHERE (@venueName IS NULL OR v.name = @venueName)";

        // Button 8 — Announcements (society name + date range filter)
        public static string RptAnnouncements = @"
    SELECT a.title, a.message, a.postedAt,
           s.name AS societyName
    FROM Announcement a
    LEFT JOIN Society s ON a.societyId = s.id
    WHERE (@societyName IS NULL OR s.name     = @societyName)
      AND (@fromDate    IS NULL OR a.postedAt >= @fromDate)
      AND (@toDate      IS NULL OR a.postedAt <= @toDate)";

        // Button 9 — Role History (society name filter)
        public static string RptMembershipRoleHistory = @"
    SELECT mrh.startDate, mrh.endDate,
           r.name  AS roleName,
           s.name  AS studentName, s.regNo,
           so.name AS societyName
    FROM MembershipRoleHistory mrh
    LEFT JOIN roles r      ON mrh.roleId      = r.id
    LEFT JOIN Membership m ON mrh.membershipId = m.id
    LEFT JOIN Student s    ON m.studentId      = s.id
    LEFT JOIN Society so   ON m.societyId      = so.id
    WHERE (@societyName IS NULL OR so.name = @societyName)";

        // Button 10 — Feedback (event title filter)
        public static string RptFeedback = @"
    SELECT f.rating, f.comment, f.submittedAt,
           s.name AS studentName,
           e.title AS eventTitle
    FROM Feedback f
    LEFT JOIN Student s ON f.studentId = s.id
    LEFT JOIN Event e   ON f.eventId   = e.id
    WHERE (@eventTitle IS NULL OR e.title = @eventTitle)";
    }
}
