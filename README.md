#Project Title: Reira_CRUDPerson
#Description: adding summery Personel bio data containing FirstName,LastName,NationalCode,BirthDate
 #data structure : table Persons
 Id int primarykey (using as Person id)
        FirstName nvarchar(255)
        LastName nvarchar(255)
        NationalCode nvarchar(10)
        BirthDate (Year int,Month int,Day int)
        #pages:
        1-index.cshtml
          Listing/reading all person data .
        2-Create.cshtml
           adding a new person by(FirstName,LastName,NationalCode,BirthDate). in this step checking NationalCode is not duplicated,             in case of entering duplicated NationalCode alerting through an error message,
           nevertheless, after inserting a new person data, redirect the enduser to page index.cshtml to see the list of perons have            been added.
        3-updating data(FirstName,LastName,NationalCode,BirthDate)
           finding a person by PersonId which is accessible through index.cshtml,loading existed data and providing availability to             changing and updating data. 
        4-Delete.cshtml
           finding a person by PersonId which is accessible through index.cshtml,if existed remove from table Persons,
           removing data phisically from data source is not a recommended way to eliminate data ,particularly is is forbiden when data would be foreign key of other tables, is should be better to have another field like "IsDeleted(bit)" to flag it as deleted row,in such cases where clause "Isdeleted=0" should be added to select scripts.
           
