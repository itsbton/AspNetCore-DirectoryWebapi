_Last Updated: _ 07/31/2022


# What is this for?
> This is a REST web API built on Asp.net 6. This is intended to do CRUD operations for the Washington State Education Directory located [here](https://eds.ospi.k12.wa.us/DirectoryEDS.aspx). This is not meant for production use.

# How do you use it?
> You can find the API urls that you can use located within the BASEURL/api/ endpoint. You can do CRUD operations for districts, educational service districts, and schools.

# API calls

> Replace http://localhost:5279/ with where the application is deployed 

## Root

***Get all the available endpoints***

> Request
````
curl --location --request GET 'http://localhost:5279/api/'
````

> Response
````
{
    "href": "http://localhost:5279/api",
    "esds": {
        "href": "http://localhost:5279/api/Esds"
    },
    "districts": {
        "href": "http://localhost:5279/api/Districts"
    },
    "schools": {
        "href": "http://localhost:5279/api/Schools"
    }
}
````
## Educational School Districts
***Get All ESDs***

> Request 
````
curl --location --request GET 'http://localhost:5279/api/Esds'
````

> Response
````
[
    {
        "administratorName": "Mike  Dunn",
        "id": 1,
        "name": "Educational Service District 101",
        "code": "32801",
        "addressLine1": "4202 S Regal Street",
        "addressLine2": "",
        "state": "Washington",
        "zipCode": "99223-7738",
        "email": "mdunn@esd101.net",
        "phone": "(509)456-2715"
    },
    ...
    {
        "administratorName": "Kevin  Chase",
        "id": 2,
        "name": "Educational Service District 105",
        "code": "39801",
        "addressLine1": "33 S 2ND AVE",
        "addressLine2": "",
        "state": "Washington",
        "zipCode": "98902-3486",
        "email": "kevin.chase@esd105.org",
        "phone": "(509)454-3113"
    }
]
````

***Get a singular ESD***

> Request 
````
curl --location --request GET 'http://localhost:5279/api/Esds/1'
````

> Response
````
{
    "administratorName": "Mike  Dunn",
    "id": 1,
    "name": "Educational Service District 101",
    "code": "32801",
    "addressLine1": "4202 S Regal Street",
    "addressLine2": "",
    "state": "Washington",
    "zipCode": "99223-7738",
    "email": "mdunn@esd101.net",
    "phone": "(509)456-2715"
}
````

***Create a new ESD***

> Request 
````
curl --location --request POST 'http://localhost:5279/api/Esds' \
--header 'Content-Type: application/json' \
--data-raw '{
    "Name" : "name",
    "Code" : "code",
    "AddressLine1" : "addressline1",
    "AddressLine2" : "addressline2",
    "State" : "state",
    "ZipCode" : "zipcode",
    "Email" : "email",
    "Phone" : "phone",
    "AdministratorName" : "adminName"
}'
````

> Response
````
{
    "administratorName": "adminName",
    "id": 0,
    "name": "name",
    "code": "code",
    "addressLine1": "addressline1",
    "addressLine2": "addressline2",
    "state": "state",
    "zipCode": "zipcode",
    "email": "email",
    "phone": "phone"
}
````

***Update an existing ESD based on ID***

> Request 
````
curl --location --request PUT 'http://localhost:5279/api/Esds/3' \
--header 'Content-Type: application/json' \
--data-raw '{
    "administratorName": "adminName",
    "name": "New Name!",
    "code": "code",
    "addressLine1": "addressline1",
    "addressLine2": "addressline2",
    "state": "state",
    "zipCode": "zipcode",
    "email": "email",
    "phone": "phone"
}'
````

> Response
````
Response 200 OK
````

***Delete an ESD***

> Request 
````
curl --location --request DELETE 'http://localhost:5279/api/Esds/3'
````

> Response
````
Response 200 OK
````

## Districts
***Get All Districts***

> Request
````
curl --location --request GET 'http://localhost:5279/api/Districts'
````
> Response
````
[
    {
        "administratorName": "Jeffrey  Thake",
        "city": "ABERDEEN",
        "esdCode": "34801",
        "esdName": "Capital Region ESD 113",
        "id": 1,
        "name": "Aberdeen School District",
        "code": "14005",
        "addressLine1": "216 N G ST",
        "addressLine2": "",
        "state": "Washington",
        "zipCode": "98520-5297",
        "email": "jthake@asd5.org",
        "phone": "(360)538-2006"
    },
    ...
    {
        "administratorName": "Thad  nelson",
        "city": "ADNA",
        "esdCode": "34801",
        "esdName": "Capital Region ESD 113",
        "id": 2,
        "name": "Adna School District",
        "code": "21226",
        "addressLine1": "PO BOX 118",
        "addressLine2": "",
        "state": "Washington",
        "zipCode": "98522-0118",
        "email": "nelsont@adnaschools.org",
        "phone": "(360)748-0362"
    }
]
````

***Get a Singular District***

> Request
````
curl --location --request GET 'http://localhost:5279/api/Districts/2'
````

> Response
````
{
    "administratorName": "Thad  nelson",
    "city": "ADNA",
    "esdCode": "34801",
    "esdName": "Capital Region ESD 113",
    "id": 2,
    "name": "Adna School District",
    "code": "21226",
    "addressLine1": "PO BOX 118",
    "addressLine2": "",
    "state": "Washington",
    "zipCode": "98522-0118",
    "email": "nelsont@adnaschools.org",
    "phone": "(360)748-0362"
}
````

***Create a District***

> Request
````
curl --location --request POST 'http://localhost:5279/api/Districts' \
--header 'Content-Type: application/json' \
--data-raw '{
    "Name" : "name",
    "Code" : "code",
    "AddressLine1" : "addressline1",
    "AddressLine2" : "addressline2",
    "State" : "state",
    "ZipCode" : "zipcode",
    "Email" : "email",
    "Phone" : "phone",
    "AdministratorName" : "adminName",
    "City" : "city",
    "EsdCode" : "esdCode",
    "EsdName" : "esdName"
}'
````

> Response
````
{
    "administratorName": "adminName",
    "city": "city",
    "esdCode": "esdCode",
    "esdName": "esdName",
    "id": 0,
    "name": "name",
    "code": "code",
    "addressLine1": "addressline1",
    "addressLine2": "addressline2",
    "state": "state",
    "zipCode": "zipcode",
    "email": "email",
    "phone": "phone"
}
````

***Update a District by ID ***

> Request
````
curl --location --request PUT 'http://localhost:5279/api/Districts/3' \
--header 'Content-Type: application/json' \
--data-raw '{
    "administratorName": "adminName",
    "City" : "city",
    "EsdCode" : "esdCode",
    "EsdName" : "esdName",
    "name": "New Name!",
    "code": "code",
    "addressLine1": "addressline1",
    "addressLine2": "addressline2",
    "state": "state",
    "zipCode": "zipcode",
    "email": "email",
    "phone": "phone"
}'
````

> Response
````
Response 204 OK
````

***Delete a District***

> Request
````
curl --location --request DELETE 'http://localhost:5279/api/Districts/3'
````

> Response
````
Response 204 OK
````

## Schools
***Get All Schools***

> Request
````
curl --location --request GET 'http://localhost:5279/api/Schools'
````
> Response
````
[
    {
        "principalName": "Vance Wing",
        "lowestGrade": "PK",
        "highestGrade": "12",
        "aypCode": "P",
        "city": "Washtucna",
        "gradeCategory": "PK-12",
        "orgCategoryList": "Public School, Regular School",
        "esdCode": "32801",
        "esdName": "Educational Service District 101",
        "leaCode": "01109",
        "leaName": "Washtucna School District",
        "id": 1,
        "name": "Washtucna Elementary/High School",
        "code": "3075",
        "addressLine1": "730 East Booth Avenue",
        "addressLine2": "",
        "state": "Washington",
        "zipCode": "99371-0688",
        "email": "vwing@tucna.wednet.edu",
        "phone": "509.646.3211"
    },
    ...
    {
        "principalName": "",
        "lowestGrade": "K",
        "highestGrade": "6",
        "aypCode": "P",
        "city": "Benge",
        "gradeCategory": "Elementary School",
        "orgCategoryList": "Public School, Regular School",
        "esdCode": "32801",
        "esdName": "Educational Service District 101",
        "leaCode": "01122",
        "leaName": "Benge School District",
        "id": 2,
        "name": "Benge Elementary",
        "code": "3142",
        "addressLine1": "2978 E. Benge-Winona Rd.",
        "addressLine2": "",
        "state": "Washington",
        "zipCode": "99105-0697",
        "email": "",
        "phone": ""
    }
]
````

***Get a Singular School***

> Request
````
curl --location --request GET 'http://localhost:5279/api/Schools/1'
````

> Response
````
{
    "principalName": "Vance Wing",
    "lowestGrade": "PK",
    "highestGrade": "12",
    "aypCode": "P",
    "city": "Washtucna",
    "gradeCategory": "PK-12",
    "orgCategoryList": "Public School, Regular School",
    "esdCode": "32801",
    "esdName": "Educational Service District 101",
    "leaCode": "01109",
    "leaName": "Washtucna School District",
    "id": 1,
    "name": "Washtucna Elementary/High School",
    "code": "3075",
    "addressLine1": "730 East Booth Avenue",
    "addressLine2": "",
    "state": "Washington",
    "zipCode": "99371-0688",
    "email": "vwing@tucna.wednet.edu",
    "phone": "509.646.3211"
}
````

***Create a School***

> Request
````
curl --location --request POST 'http://localhost:5279/api/Schools/' \
--header 'Content-Type: application/json' \
--data-raw '{
                "Code" : "code",
                "Name" : "name",
                "AddressLine1" : "addressline1",
                "AddressLine2" : "addressline2",
                "State" : "state",
                "ZipCode" : "zipcode",
                "Phone" : "phone",
                "Email" : "email",
                "City" : "city",
                "PrincipalName" : "prinicpalName",
                "LowestGrade" : "lowestGrade",
                "HighestGrade" : "highestGrade",
                "AypCode" : "aypCode",
                "GradeCategory" : "gradeCategory",
                "OrgCategoryList" : "orgCategoryList",
                "EsdCode" : "esdCode",
                "EsdName" : "esdName",
                "LeaCode" : "leaCode",
                "LeaName" : "leaName"
}'
````

> Response
````
{
    "principalName": "prinicpalName",
    "lowestGrade": "lowestGrade",
    "highestGrade": "highestGrade",
    "aypCode": "aypCode",
    "city": "city",
    "gradeCategory": "gradeCategory",
    "orgCategoryList": "orgCategoryList",
    "esdCode": "esdCode",
    "esdName": "esdName",
    "leaCode": "leaCode",
    "leaName": "leaName",
    "id": 0,
    "name": "name",
    "code": "code",
    "addressLine1": "addressline1",
    "addressLine2": "addressline2",
    "state": "state",
    "zipCode": "zipcode",
    "email": "email",
    "phone": "phone"
}
````

***Update a School by ID***

> Request
````
curl --location --request PUT 'http://localhost:5279/api/Schools/3' \
--header 'Content-Type: application/json' \
--data-raw '{
                "Code" : "code",
                "Name" : "New Name!",
                "AddressLine1" : "addressline1",
                "AddressLine2" : "addressline2",
                "State" : "state",
                "ZipCode" : "zipcode",
                "Phone" : "phone",
                "Email" : "email",
                "City" : "city",
                "PrincipalName" : "prinicpalName",
                "LowestGrade" : "lowestGrade",
                "HighestGrade" : "highestGrade",
                "AypCode" : "aypCode",
                "GradeCategory" : "gradeCategory",
                "OrgCategoryList" : "orgCategoryList",
                "EsdCode" : "esdCode",
                "EsdName" : "esdName",
                "LeaCode" : "leaCode",
                "LeaName" : "leaName"
}'
````

> Response
````
Response 204 OK
````

***Delete a School By ID***

> Request
````
curl --location --request DELETE 'http://localhost:5279/api/Schools/3'
````

> Response
````
Response 204 OK
````

# Who are the primary contacts?
> Developer: Brenton Sablan 

# Where is it located?
> Development: Only in development on local machines

# Future Updates
> Authentication and roles
> Validation on inserts and updates
