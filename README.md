#Technical Task
##Overview
This application provides API for data that related the structure of company.

##Getting Started
For starting application use Microsoft Visual Studio 2017.
LocalDB is used in the application and no any configuration needed for run.

##External authentication
LinkedIn external provider uses for authentication. 
Go to the [LinkedIn Developer Portal](https://developer.linkedin.com/) and select My Apps from the top menu. Click on the Create Application button. You will need to complete all the information for your application, and once you are done click on the Submit button.
You will be taken to a page which displays the detail about your new application, including the Client ID and Client Secret.

In Visual Studio you may right click on the TechnicalTask project and select "Manage User Secrets" in context menu.
You should paste you own values between brackets in the secret.json file.
Example: 
```json
"Authentication:LinkedIn:ClientID": <client_id>, 
"Authentication:LinkedIn:ClientSecret": <client_secret>.
```

Or execute the following commands in your project working directory to store the user secrets:
```powershell
dotnet user-secrets set Authentication:LinkedIn:ClientID <client_id>
dotnet user-secrets set Authentication:LinkedIn:ClientSecret <client-secret>
```

##Request examples
Json templates for API testing.
Tip: Arrays in objects are not required, but if you want to create/update included object(-s) you may initialize array of the current (each) object.

###/api/Business 
```json
[POST]
{
  "name": "string",
  "countryId": 0,
  "families": [
    {
      "name": "string",
      "businessId": 0,
      "offerings": [
        {
          "name": "string",
          "familyId": 0,
          "departments": [
            {
              "name": "string",
              "offeringId": 0
            }
          ]
        }
      ]
    }
  ]
}

[PUT]
{
  "id": 0,
  "name": "string",
  "countryId": 0,
  "families": [
    {
      "id": 0,
      "name": "string",
      "businessId": 0,
      "offerings": [
        {
          "id": 0,
          "name": "string",
          "familyId": 0,
          "departments": [
            {
              "id": 0,
              "name": "string",
              "offeringId": 0
            }
          ]
        }
      ]
    }
  ]
}
```
------------------------------------------------

###/api/Countries
```json
[POST]
{
  "organizationId": 0,
  "name": "string",
  "code": "string"
}

[PUT]
{
  "organizationId": 0,
  "name": "string",
  "code": "string"
}
```
------------------------------------------------

###/api/Departments
```json
[POST]
{
  "name": "string",
  "offeringId": 0
}

[PUT]
{
  "id": 0,
  "name": "string",
  "offeringId": 0
}
```
------------------------------------------------

###/api/Families
```json
[POST]
{
  "name": "string",
  "businessId": 0,
  "offerings": [
    {
      "name": "string",
      "familyId": 0,
      "departments": [
        {
          "name": "string",
          "offeringId": 0
        }
      ]
    }
  ]
}

[PUT]
{
  "id": 0,
  "name": "string",
  "businessId": 0,
  "offerings": [
    {
      "id": 0,
      "name": "string",
      "familyId": 0,
      "departments": [
        {
          "id": 0,
          "name": "string",
          "offeringId": 0
        }
      ]
    }
  ]
}
```
------------------------------------------------

###/api/Offerings
```json
[POST]
{
  "name": "string",
  "familyId": 0,
  "departments": [
    {
      "name": "string",
      "offeringId": 0
    }
  ]
}

[PUT]
{
  "id": 0,
  "name": "string",
  "familyId": 0,
  "departments": [
    {
      "id": 0,
      "name": "string",
      "offeringId": 0
    }
  ]
}
```
------------------------------------------------

###/api/Organizations
```json
[POST]
{
  "name": "string",
  "code": "string",
  "organizationType": 1 (You can use numbers from 1 to 6),
  "owner": "string",
  "organizationCountries": [
    {
      "organizationId": 0,
      "countryId": 0,
      "country": {
        "name": "string",
        "code": "string",
        "businesses": [
          {
            "name": "string",
            "countryId": 0,
            "families": [
              {
                "name": "string",
                "businessId": 0,
                "offerings": [
                  {
                    "name": "string",
                    "familyId": 0,
                    "departments": [
                      {
                        "name": "string",
                        "offeringId": 0
                      }
                    ]
                  }
                ]
              }
            ]
          }
        ]
      }
    }
  ]
}

[PUT]
{
  "id": 0,
  "name": "string",
  "code": "string",
  "organizationType": 1,
  "owner": "string",
  "organizationCountries": [
    {
      "id": 0,
      "organizationId": 0,
      "countryId": 0,
      "country": {
        "id": 0,
        "name": "string",
        "code": "string",
        "businesses": [
          {
            "id": 0,
            "name": "string",
            "countryId": 0,
            "families": [
              {
                "id": 0,
                "name": "string",
                "businessId": 0,
                "offerings": [
                  {
                    "id": 0,
                    "name": "string",
                    "familyId": 0,
                    "departments": [
                      {
                        "id": 0,
                        "name": "string",
                        "offeringId": 0
                      }
                    ]
                  }
                ]
              }
            ]
          }
        ]
      }
    }
  ]
}
```
------------------------------------------------

###/api/Users
```json
[POST]
{
  "name": "string",
  "surname": "string",
  "email": "string",
  "address": "string"
}

[PUT]
{
  "id": 0,
  "name": "string",
  "surname": "string",
  "email": "string",
  "address": "string"
}
```