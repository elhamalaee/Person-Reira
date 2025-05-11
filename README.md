
# Project Title: Reira_CRUDPerson

## Description
Adding summary personnel bio data containing FirstName, LastName, NationalCode, BirthDate.

## Data Structure
### Table: Persons
- **Id**: `int` (Primary Key, used as Person ID)
- **FirstName**: `nvarchar(255)`
- **LastName**: `nvarchar(255)`
- **NationalCode**: `nvarchar(10)`
- **BirthDate**: 
  - **Year**: `int`
  - **Month**: `int`
  - **Day**: `int`

## Pages
1. **index.cshtml**
   - Listing/reading all person data.

2. **Create.cshtml**
   - Adding a new person by FirstName, LastName, NationalCode, BirthDate.
   - Checking NationalCode is not duplicated; if duplicated, alerting through an error message.
   - After inserting new person data, redirecting the end user to index.cshtml to see the list of persons added.

3. **Update.cshtml**
   - Updating data (FirstName, LastName, NationalCode, BirthDate).
   - Finding a person by PersonId accessible through index.cshtml, loading existing data, and providing availability to change and update data.

4. **Delete.cshtml**
   - Finding a person by PersonId accessible through index.cshtml; if existing, remove from table Persons.
   - Removing data physically from the data source is not recommended, especially if the data is a foreign key in other tables. It is better to have another field like `IsDeleted(bit)` to flag it as a deleted row. In such cases, add the clause `IsDeleted=0` to select scripts.

           
