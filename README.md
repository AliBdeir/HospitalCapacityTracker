# Hospital Bed Tracker
A localization-supported ASP.NET Core website that provides an easy way for websites to update statistics concerning bed capacity.

---

## Technologies
- ASP.NET Core 5 - Razor Pages
- Microsoft Entity Framework Core 5
- Microsoft SQL Server

![preview](https://i.imgur.com/qUuEyNK.png "Preview Image")

## Setup
### Database
1. To get started, create an `appsettings.json` in the root of the `HospitalBedSystem` directory. Refer to the [Entity Framework Core Documentation](https://docs.microsoft.com/en-us/ef/core/miscellaneous/connection-strings) to set the connection string. *Note: Use DefaultConnection as the database alias.*

2. Open the Nuget Package Manager Console in Visual Studio by going to Tools -> NuGet -> Package Manager Console

3. Select the Data project in the dropdown at the top of the package manager console.

4. Create the latest EF Core migrations:
    ```
    Add-Migration "Initial Migration"
    ```
5. Update your database with the migration:
    ```
    Update-Database
    ```

    *To learn more about Entity Framework Core and migrations, refer to the [Official Migrations Overview](https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli) or, to learn from scratch, the Official Getting Started Guide.*

Respective tables should be created in your database.

### Localizaiton
The resource files are located in the `HospitalBedTracker` project under the `Resources` directory. The `CommonResources.[language].resx` files are strings not specific to a certain page, and can be found grouped under the `CommonResource.cs` in Visual Studio. The page-specific string resources can be foun under the `Pages` direcotory.

#### To Add a Language
1. Add a new `CultureInfo` to the public static array in `Configuration.cs` in the `Globals` project.

2. Duplicate a `CommonResources` reference resource file of your choice, renaming it to `CommonResources.[2-letter language ISO code].resx` under the `Resources` directory in the `HospitalBedTracker` project.

3. For every page under the `Resources/Pages` directory, duplicate its respective resource file. Be sure to follow the format the already-existing resource files comply with.

    **Note 1:** For both steps 2 and 3, once you add a resource file, open it in Visual Studio and change the Access Modifier to Public. The dropdown is at the top ribbon.

    **Note 2:** Both steps 2 and 3 will probably give you *resource file*-related errors in the Error List. Restarting visual studio should fix this, but you should be able to compile nonetheless.

4. Add your translations!

## TODO
1. Restrict the Register page to an administrator account.
2. Make the login page redirect to the Hospital Manager page after logging in.
3. Give hospitals an ability to update their thumbnail, Google Maps URL, and hospital name.