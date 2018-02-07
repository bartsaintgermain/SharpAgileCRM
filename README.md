[![Build status](https://ci.appveyor.com/api/projects/status/na2jqgp3n6b6ecbr?svg=true)](https://ci.appveyor.com/project/bartsaintgermain/sharpagilecrm)

# C# API for AgileCRM

You can use SharpAgileCRM to interact with Agile CRM using any .NET programming language, such as C# or Visual Basic.

## Getting started

To interact with AgileCRM, you create an instance of the `AgileCRM` class. The constructor takes three parameters, the name of your account, your e-mail address and the API key.

You can determine the account name from the URL you use to sign in into AgileCRM. For example, if you connect to https://company.agilecrm.com, your account name would be `company`. 

You can access the API Key from Admin Settings -> API & Analytics -> API Key. You'll need to use the first one (API Key for REST client) for use with SharpAgileCRM.

```csharp
AgileCRM crm = new AgileCRM("YOUR_ACCOUNT", "YOUR_EMAIL", "YOUR_API_KEY");
```

## Listing all contacts

You can use this sample code block to list all the contacts in your AgileCRM account:

```csharp
AgileCRM crm = new AgileCRM("YOUR_ACCOUNT", "YOUR_EMAIL", "YOUR_API_KEY");

var persons = await Person.GetPersonsAsync(crm, 1000).ConfigureAwait(false);

int i = 0;

foreach (var person in persons)
{
    Console.WriteLine($"{person.FirstName} {person.LastName}");
}
```
