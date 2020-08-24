# LibraryManagementSystem
C# Windows Form Library Management System

## Warning
This project repository is the final project of **PRN292 (C# and .NET) in Software Engineering, FPT University.** This project is only a simulation for existing applications, does not apply in real life, and replaces any applications.
We use this README.md file instead of Software Design Document.

## Group Members - ID (Roles)
- Le Tuan Anh - HE140428 (**Leader**, Document Preparation, Product Checking)
- Hoang Thuy Tien - HE141513 (Document Preparation, Frontend Development)
- Nguyen Tuan Ngoc - HE141341 (Backend Development)
- Ha Hong Son - HE140611 (Backend Development)

## 1. Description
This document describes version 1.0 for Library Management System. It is divided into the following sections:
-	In section 2, an overview of the system’s requirements will be provided, including list of system user, use cases, use case diagram, and activity diagrams which describes the most important use case scenarios.
-	In section 3, an E-R diagram and all tables of the system will be presented in detail.
-	In section 4, all classes organized in the layers and their behaviors (sequence diagrams) for the most frequently used use cases will be presented.
-	In section 5, the screen prototypes will be presented.

## 2. Software Requirements Overview
### 2.1	List of System users
#### 2.1.1	Librarian
A librarian is a person who works professionally in a library, providing access to information to users.
### 2.2	List of use cases
- UC-1:	Borrow Books(s)
- UC-2:	Return Book(s)
- UC-3:	Reserve Book
- UC-4:	Register Book
- UC-5:	Register Borrower 
- UC-6:	Renew Borrowed Book
### 2.3	Use Case Diagram
![Use Case Diagram](https://i.imgur.com/5MIKUK9.png)
### 2.4	Activity diagrams of Use Case scenarios
#### 2.4.1 Activity diagram for Use Case “Borrow Book"
![AD Borrow Book](https://i.imgur.com/D042vwa.png)
#### 2.4.2	Activity diagram for Use Case “Return Book”
![AD Return Book](https://i.imgur.com/fzWe6wU.png)
#### 2.4.3	Activity diagram for Use Case “Reserve Book”
![Reverse Book](https://i.imgur.com/IR18Sb1.png)

## 3. Data Model
### 3.1 Entity Relationship Diagram
![ERD](https://i.imgur.com/UppeyPq.png)
### 3.2	Table Details
#### 3.2.1	Table Name: Member
| Field Name | Type | Size | Note |
| --- | --- | --- | --- |
| MemberNumber | integer | 10 | PRIMARY KEY |
| Name | string | 150 | Not NULL |
| Sex | boolean |  | Not NULL |
| Address | string | 150 | Not NULL |
| Telephone | string | 15 | Not NULL |
| Email | string | 50 | Not NULL |
#### 3.2.2	Table Name: Book
| Field Name | Type | Size | Note |
| --- | --- | --- | --- |
| BookNumber | integer | 10 | PRIMARY KEY |
| Title | string | 150 | Not NULL |
| Author | string | 150 | Not NULL |
| Publisher | string | 150 | Not NULL |
#### 3.2.3	Table Name: Copy
| Field Name | Type | Size | Note |
| --- | --- | --- | --- |
| CopyNumber | integer | 10 | PRIMARY KEY |
| BookNumber | integer | 10 | Foreign key, Refers to Book |
| SequenceNumber | integer | 10 | Sequence number for each copy of the same book  |
| Type | integer | 10 | 0: Available, 1: Borrowed, 2: Referenced |
| Price | double |  | Allow NULL |
#### 3.2.4	Table Name: Circulated Copy
| Field Name | Type | Size | Note |
| --- | --- | --- | --- |
| ID | integer | 10 | PRIMARY KEY |
| MemberNumber | integer | 10 | Foreign key, Refers to Member |
| CopyNumber | integer | 10 | Foreign key, Refers to Copy |
| BorrowDate | date |  | Not NULL |
| DueDate | date |  | Allow NULL |
| ReturnDate | date |  | Allow NULL |
| FineAmount | double |  | Allow NULL |
#### 3.2.5	Table Name: Reservation
| Field Name | Type | Size | Note |
| --- | --- | --- | --- |
| ID | integer | 10 | PRIMARY KEY |
| MemberNumber | integer | 10 | Foreign key, Refers to Member |
| BookNumber | integer | 10 | Foreign key, Refers to Book |
| Date | datetime |  | Not NULL |
| Status | integer | 10 | 0: Available, 1: Reserved |

## 4.	Class Diagram
### 4.1 List of Classes in the Layers
![Classes](https://i.imgur.com/nktMmqK.png)

### 4.2	Modeling the Class Behaviors
#### 4.2.1  Sequence diagram for Use Case “Borrow copy”
![Sequence Borrow](https://i.imgur.com/3meVeNV.png)
#### 4.2.2	Sequence diagram for Use Case “Return copy”
![Sequence Return](https://i.imgur.com/yPyz3Ob.png)
#### 4.2.3  Sequence diagram for use case “Reserve book"
![Sequence Reserve](https://i.imgur.com/6gH2LoI.png)

## 5.	User Interface Model Design
### 5.1	User interface screen design
#### 5.1.1  Screen “Register books”
![Reg Book](https://i.imgur.com/wHiSV8s.png)
#### 5.1.2  Screen “Register Member”
![Reg Mem](https://i.imgur.com/JICLlJG.png)
#### 5.1.3  Screen “Borrow book”
![Borrow](https://i.imgur.com/okgkUX0.png)
#### 5.1.4  Screen “Return book”
![Return](https://i.imgur.com/Wn8lc5r.png)
#### 5.1.5  Screen “Reserve books”
![Reserve](https://i.imgur.com/3wAB9jS.png)
#### 5.1.6  Screen “Renew borrowed book”
![Renew](https://i.imgur.com/4Cct06S.png)
### 5.2 Interface Flow Diagram
![IFD](https://i.imgur.com/1disQol.png)
