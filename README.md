# 200825-dotnet-views-ic

## Movie Rental app with Razor

### Set Up
- Create a new .NET MVC app called `MovieRentals` using the .NET CLI
- Run the application without debugging
- View the application in the browser
- Create a new postman request collection for the application

### Assignment
- Create a `Movies` controller that extends the base Controller class

- Create a `Movie` class in `Models` with the following properties:
`MovieId` int
`MovieName` string
`MovieGenre` string
`ReleaseYear` int

- Create a `Customer` class in `Models` with the following properties:
`CustomerId` int
`CustomerName` string
`PremiumMember` bool

- Create stub data list of movies in controller by adding 3 Movies of your choosing to a List<Movie> called `MoviesList`

## ViewModels
- Create a new `ViewModels` folder
- In the `ViewModels` folder create a new View Model called `MovieRentalDetailsModel` with the following properties:
`Movie` Movie
`Customers` List<Customer>
  
## MovieInfo Endpoint
- Add an action to the `Movies` controller called `MovieInfo` that accepts an int movie ID 
- Add a corresponding view of the same name in the `Views` folder
- In the controller action, find the movie in the list of stub data and pass the id passsed in, and the matching (if a match) movie name, genre, and release year to the view using `ViewData`
- In the corresponding view use conditional rendering to display the movie properties or the HTML `Movie was not found for ID [WHATEVERID]`

## MovieRentalHistory Endpoint
- Add an action to the `Movies` controller called `MovieRentalHistory` that accepts an int movie ID 
- Add a corresponding view of the same name in the `Views` folder that will render the movie details and a list of rental customers from a `MovieRentalDetailsModel` instance
- In the action, create a new `MovieRentalDetailsModel`
- Create a new `Movie` and add it to the `MovieRentalDetailsModel`
- Create a List of 3 customers and add the List to the `MovieRentalDetailsModel`
- Render the corresponding view by passing in the ViewModel

## User Interface
- Modify the navigation bar to add links for `Display Movie 1` and `Rental Details'
  - `Display Movie 1` link should use the `MovieInfo` endpoint to display the movie with ID == 1
  - `Rental Details` link should use the `MovieRentalHistory` endpoint to display the movie details and the customers who rented it (that you added in the action)
