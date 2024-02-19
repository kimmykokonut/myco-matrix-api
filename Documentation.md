# Myco Matrix API
## an api holding fungi facts
_by Henry Oberholtzer & Kim Robinson_

Base URL: localhost:5000/api

This API is designed to provide facts about mushrooms found in North America.  Explore the API below and make API calls.  Only authorized users can access POST, PUT and DELETE endpoints. 

### Endpoints

```
GET http://localhost:5000/api/mushrooms/
GET http://localhost:5000/api/mushrooms/{id}
POST http://localhost:5000/api/mushrooms/
PUT http://localhost:5000/api/mushrooms/{id}
DELETE http://localhost:5000/api/mushrooms/{id}
```
* Note: the `{id}` in the URL is a variable and should be replaced with the id of the mushroom a user wants to access.

 -   A GET endpoint at http://localhost:5000/api/mushrooms will return all mushroom objects.
 -   A GET endpoint at http://localhost:5000/api/mushrooms/{id} will return one mushroom object based on its mushroomId property.
 -   A POST endpoint at http://localhost:5000/api/mushrooms will add a new mushroom to our database and requires a request body with an object literal of a mushroom.
 -   A PUT endpoint at http://localhost:5000/api/mushrooms/{id} will edit the object in entired based on it's MushroomId property
 -   A DELETE endpoint at  http://localhost:5000/api/mushrooms/{id} will delete the object based on its MushroomId property

### Optional Query String Parameters for GET Request
#### These query strings are a way to filter the mushroom objects
| Parameter   | Type        |  Required    | Description |
| ----------- | ----------- | -----------  | ----------- |
| Common Name     | String      | not required | Returns mushrooms with a matching common name |
| Genus        | String      | not required | Returns mushrooms with a matching genus value |
| Species  | String      | not required | Returns mushrooms with a matching species value |
| Gill Type  | String      | not required | Returns mushrooms with a matching gill type value (None, Gills, Ridged, Pores, Polypore) |
| Toxicity Level  | Integer      | not required | Returns mushrooms with a a toxicity level greater or equal to 5 |

#### Example Query

The following query will return all mushrooms with the genus "Craterellus":

```
GET http://localhost:5000/api/mushrooms?genus=craterellus
```

It's possible to include multiple query strings by separating them with an `&`:

```
GET http://localhost:5000/api/mushrooms?species=Galerina&toxicityLevel=5
```
### Additional requirements for PUT request
When making a PUT request to `http://localhost:5000/api/mushrooms/{id}`, you need to include a **body** that includes the mushrooms's `mushroomId` property. Here's an example body in JSON:

```json
{
    "MushroomId": 1,
    "CommonName": "Deadly Galerina", 
    "Genus": "Galerina", 
    "Species": "marginata", 
    "GillType": "Gills", 
    "ImageURL": "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/Craterellus_cornucopioides_Eestis.JPG/800px-Craterellus_cornucopioides_Eestis.JPG", 
    "ToxicityLevel": 10, 
    "Notes": "contains amatoxins, has been confused with Psilocybe stuntzii" 
},
```

And here's the PUT request we would send the previous body to:

```
http://localhost:5000/api/mushrooms/1
```

Notice that the value of `MushroomId` needs to match the id number in the URL. In this example, they are both 1.
 

Coming Features:
* PATCH request
* Pagination
* Object within object?
* API key

