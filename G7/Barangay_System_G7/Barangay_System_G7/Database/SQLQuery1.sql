USE commngtcc105;

-- Create Seminar Table
CREATE TABLE G7_Seminars (
    SeminarID INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(255),
    Description NVARCHAR(500),
    Date DATE,
    Location NVARCHAR(255),
    Speaker NVARCHAR(255)
);

-- Create Assistance Requests Table
CREATE TABLE G7_AssistanceRequests (
    AssistanceID INT PRIMARY KEY IDENTITY(1,1),
    ResidentName NVARCHAR(255),
    AssistanceType NVARCHAR(100),
    DocumentPath NVARCHAR(500),
    DateSubmitted DATETIME DEFAULT GETDATE()
);

-- Create Payout Table
CREATE TABLE G7_Payouts (
    PayoutID INT PRIMARY KEY IDENTITY(1,1),
    ResidentName NVARCHAR(255),
    Amount DECIMAL(10, 2),
    PaymentMode NVARCHAR(50),
    GCashNumber NVARCHAR(20) NULL,
    Status NVARCHAR(50) DEFAULT 'Pending',
    DateProcessed DATETIME
);
