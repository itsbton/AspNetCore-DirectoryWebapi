_Last Updated: _ 07/31/2022


# What is this for?
> This is a REST web API built on Asp.net 6. This is intended to do CRUD operationas for the Washington State Education Directory located [here](https://eds.ospi.k12.wa.us/DirectoryEDS.aspx). This is not meant for production use.

# How do you use it?
> You can find the API urls that you can use located within the BASEURL/api/ endpoint. You can do CRUD operations for districts, educational service districts, and schools.

# Example API calls
## Root

> Get all the available endpoints
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

## Districts
> Get All Districts
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

# Who are the primary contacts?
> Developer: Brenton Sablan 

# Where is it located?
> Development: Only in development on local machines