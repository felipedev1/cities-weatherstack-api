<h1 align="center">
  Cities Weatherstack API
</h1>

<div align="center">
  <img alt="GitHub repo size" src="https://img.shields.io/github/repo-size/felipedev1/cities-weatherstack-api">
  <img alt="GitHub top language" src="https://img.shields.io/github/languages/top/felipedev1/cities-weatherstack-api">
  <img alt="GitHub Repo stars" src="https://img.shields.io/github/stars/felipedev1/cities-weatherstack-api?style=social">
</div>


<p align="center">
  <a href="#About">About</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#Motivation">Motivation</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#Requirements">Requirements</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#Installation">Installation</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#Usage">Usage</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#License">License</a>
</p>

## About

This API has a letter search filter, which returns successful queries to the [WeatherStack API](https://weatherstack.com/). To add new queries that were successful, you need to save them in the database.

## Motivation

This project was made for a challenge made by a job selection process.
The API was made especially to save the city queries made to the [WeatherStack API](https://weatherstack.com/) and provide a better user experience when typing in the search bar and ensuring a certain result.

## Requirements

To run this project you'll need the following programs installed on your machine:

+ [.NET](https://dotnet.microsoft.com/download)
+ [Visual Studio 2019](https://visualstudio.microsoft.com/pt-br/downloads/)

## Installation

To install the project open your command prompt and run the following command:

  ```shell
	  git clone https://github.com/felipedev1/cities-weatherstack-api.git
  ```

To create the local database you will need to do the following steps:

1. Open the project in Visual Studio 2019
2. Open the Package Manager Console
3. Run the following command
  ```shell
    Update-Database
  ```

## Usage

  Base API URL: `https://localhost:44360`

  ### Run

  To run the project just click on the IIS Express, and it will open at the link https://localhost:44360/swagger, showing all the endpoints.

  ### Main Endpoints
  ---

  **Get cities by letter**

  * **URL**

    /api/cities

  * **Method:**

    `GET`

  * **URL Params**
 
    `query=[string]`

  * **Data Params**

    None

  * **Success Response:**

    * **Code:** 200 <br />
      **Content:** `{ id: number, cityName : string, country: string, region: string }`
  
  ___

  **Save cities**

  * **URL**

    /api/cities

  * **Method:**

    `POST`

  * **URL Params**
 
    None

  * **Data Params**

    `{ cityName: string, country: string, region: string }`  

  * **Success Response:**

    * **Code:** 200 <br />
      **Content:** `{ id: number, cityName : string, country: string, region: string }`
  ---
 

## License

This project is under the MIT license. See the [LICENSE](https://github.com/felipedev1/cities-weatherstack-api/blob/master/LICENSE) for details.
