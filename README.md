# Product Middleware REST API

This project implements a middleware REST API for retrieving products from various sources. Currently, it supports fetching products from REST API sources. The API allows advanced product filtering and searching by name.

## Technologies

- .NET 8
- ASP.NET Web API
- Entity Framework

## Features

- **Retrieve product list**: Returns a list of products with an image, name, price, and short description (up to 100 characters).
- **Retrieve product details**: Returns details of a specific product.
- **Product filtering**: Allows filtering products by category and price.
- **Search products by name**: Searches products based on the entered text.

### "Nice to have" features

- Caching of search and filtering results
- Logging (Info, Warning, Error)

## Project Structure

The project is structured according to recommended best practices and conventions:

- `Controllers` - Contains API controllers
- `Models` - Contains data models and DTOs
- `Services` - Contains business logic
- `Interfaces` - Contains interfaces
- `Repositories` - Contains data access code

## Testing the Application

### Prerequisites:

- You need to have Visual Studio installed with the ASP.NET framework.

To test this application, you need to download the zip file of this repository and extract it. Once extracted, open the .sln (solution) file. Then, run the program. After that, enter the following in your browser: "http://localhost:5555api", replacing "api" with one of the APIs listed below.

## API Documentation

### Endpoints

| Endpoint | Method | Description | Example Request |
|----------|--------|-------------|-----------------|
| `/api/products` | GET | Returns a list of products with an image, name, price, and short description (up to 100 characters). | `GET /api/products` |
| `/api/products/{id}` | GET | Returns the details of a single product based on its ID. | `GET /api/products/1` |
| `/api/products/search` | GET | Searches products by name. | `GET /api/products/search?title=Product` |
| `/api/products/categories/{category}` | GET | Filters products by category and price. | `GET /api/products/categories/electronics?minPrice=50&maxPrice=500` |

**Example Request:**

```http

GET /api/products

[
    {
        "title": "Product 1",
        "description": "Short description of the product...",
        "thumbnail": "http://example.com/image1.jpg",
        "price": 99.99
    },
    {
        "title": "Product 2",
        "description": "Another short description...",
        "thumbnail": "http://example.com/image2.jpg",
        "price": 149.99
    }
]
GET /api/products/1

{
  "id": 1,
  "title": "Essence Mascara Lash Princess",
  "description": "The Essence Mascara Lash Princess is a popular mascara known for its volumizing and lengthening effects. Achieve dramatic lashes with this long-lasting and cruelty-free formula.",
  "category": "beauty",
  "price": 9.99,
  "discountPercentage": 7.17,
  "rating": 4.94,
  "stock": 5,
  "tags": [
    "beauty",
    "mascara"
  ],
  "brand": "Essence",
  "sku": "RCH45Q1A",
  "weight": 2,
  "dimensions": {
    "width": 23.17,
    "height": 14.43,
    "depth": 28.01
  },
  "warrantyInformation": "1 month warranty",
  "shippingInformation": "Ships in 1 month",
  "availabilityStatus": "Low Stock",
  "reviews": [
    {
      "rating": 2,
      "comment": "Very unhappy with my purchase!",
      "date": "2024-05-23T08:56:21.618Z",
      "reviewerName": "John Doe",
      "reviewerEmail": "john.doe@x.dummyjson.com"
    },
    {
      "rating": 2,
      "comment": "Not as described!",
      "date": "2024-05-23T08:56:21.618Z",
      "reviewerName": "Nolan Gonzalez",
      "reviewerEmail": "nolan.gonzalez@x.dummyjson.com"
    },
    {
      "rating": 5,
      "comment": "Very satisfied!",
      "date": "2024-05-23T08:56:21.618Z",
      "reviewerName": "Scarlett Wright",
      "reviewerEmail": "scarlett.wright@x.dummyjson.com"
    }
  ],
  "returnPolicy": "30 days return policy",
  "minimumOrderQuantity": 24,
  "meta": {
    "createdAt": "2024-05-23T08:56:21.618Z",
    "updatedAt": "2024-05-23T08:56:21.618Z",
    "barcode": "9164035109868",
    "qrCode": "https://dummyjson.com/public/qr-code.png"
  },
  "images": [
    "https://cdn.dummyjson.com/products/images/beauty/Essence%20Mascara%20Lash%20Princess/1.png"
  ],
  "thumbnail": "https://cdn.dummyjson.com/products/images/beauty/Essence%20Mascara%20Lash%20Princess/thumbnail.png"
}
GET /api/products/search?title=Product

[
    {
        "title": "Product 1",
        "description": "Short description of the product...",
        "thumbnail": "http://example.com/image1.jpg",
        "price": 99.99
    },
    {
        "title": "Product 2",
        "description": "Another short description...",
        "thumbnail": "http://example.com/image2.jpg",
        "price": 149.99
    }
]
GET /api/products/categories/electronics?minPrice=50&maxPrice=500

[
    {
        "title": "Product 1",
        "description": "Short description of the product...",
        "thumbnail": "http://example.com/image1.jpg",
        "price": 99.99
    },
    {
        "title": "Product 2",
        "description": "Another short description...",
        "thumbnail": "http://example.com/image2.jpg",
        "price": 149.99
    }
]
```
