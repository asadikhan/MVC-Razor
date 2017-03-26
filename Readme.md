# Single Page App Using MVC5, Razor and JSON Rest API
This is a Single Page Application build using ASP.NET MVC5 and Razor. It also shows server side call to a mock RESTful api (using GET verb) and an AJAX call to the same api (using POST verb).

## Mock JSON Restful API
This application makes use of JSONPlaceHolder which is a Fake Online REST API for Testing and Prototyping [https://jsonplaceholder.typicode.com/]. Specifically, the UserModelBAL class uses HttpClient to call the Users api to get 10 users back from the API. Also, in one of the views we have a client side javascript function that has an AJAX call calling the same API to create a new user. 

**NOTE: As per the documentation of this mock API, the resource will not be really created on the server but it will be faked as if. **

## Application Overview

The application has one controller called HomeController that has methods that are tied to Razor Views and PartialViews. The UserList method uses server side HttpClient object to retreive JSON collection from the API and then hands it to a PartialView which is responsible for rendering the collection in an unnumbered list. The CallToAction method takes in a URI and and Image URI and spits out the same through another partial view. 

On the page, you can click the Add User button to invoke client side AJAX call to call the same service and then update the unnumbered list. Multiple clicks create multiple copies of the same user, this was by design. 

## Unit Testing

There are a few unit tests included to verify the controller actions return the correct view, as well as the data is verified in another test. Unit Tests for the model or calling the JSON API were not included but can be added as an exercise. 

![alt tag](https://raw.githubusercontent.com/asadikhan/MVC-Razor/master/samplebot/images/Screenshot.png)