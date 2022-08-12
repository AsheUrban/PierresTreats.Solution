# Week 12 Independent Project: Pierre's Treats and Flavors Solution!

#### A website that allows Pierre to track his treats and flavor comobs!

#### By Ashe Urban

## Technologies Used

* _C#_
* _CSHTML_
* _CSS_
* _Entity Framework_
* _SQL Database_
* _dotnet_
* _Markdown_

## Description

_Pierre is back! He wants you to create a new application to market his sweet and savory treats. This time, he would like you to build an application with user authentication and a many-to-many relationship. Here are the features he wants in the application:_

* _User Authentication._
* _Authorize users to Create, Update, or Delete._
* _Allow all users to Read._
* _Many to Many relationship between Flavors and Treats._
* _Splash page with all treats and flavors listed._
* _Details pages with linked relationships._


_Link to assignment:_ https://epicenter.epicodus.com/courses/968/code_reviews/5863

### Pierre's Sweets and Savory Treats!

_Your code will be reviewed for the following objectives:_

* _Does at least one of your classes have all CRUD methods implemented in your app?_
* _Are you able to view both sides of the many-many relationship? For a particular instance of a class, are you able to view all of the instances of the other class that are related to it?_
* _Are users able to register, log in and log out with Identity?_
* _Is Create, Update and Delete functionality limited to authenticated users?_
* _Build files and sensitive information are included in .gitignore file and is not to be tracked by Git, and includes instructions on how to create the appsettings.json and set up the project._
* _Project is in a polished, portfolio-quality state._
* _The prompt’s required functionality and baseline project requirements are in place by the deadline._

## Setup/Installation Requirements

* _Clone or download responsitory to your local._
* _Cd into Factory and run dotnet restore, dotnet build to confirm the project has no errors._
* _Touch appsettings.json and add the following configuration:_

{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[pierres_treats];uid=root;pwd=[password];"
  }
}

* _Run dotnet ef migrations add Initial and/OR dotnet ef database update to build database if migrations folders are in place._
* _Then use dotnet watch run to run web application._

_NOTE:_ [password] should be replaced by your password. Do not include square brackets in final configuration.

## Known Bugs -- IMPORTANT --

* _Need to address UI/UX_

## License

* MIT

## Contact Information

_Please contact me with any questions or contribuitions, ashe@goldentongue.com_

Copyright(c) August 2022 Ashe Urban