# Aspnet-api
Stručni zadatak za .NET developera.

## Endpointovi

| Endpoint | Metoda | Opis | Primjer zahtjeva |
|----------|--------|------|------------------|
| `/api/products` | GET | Vraća listu proizvoda sa slikom, nazivom, cijenom i skraćenim opisom (do 100 znakova). | `GET /api/products` |
| `/api/products/{id}` | GET | Vraća detalje jednog proizvoda na temelju njegovog ID-a. | `GET /api/products/1` |
| `/api/products/search` | GET | Pretražuje proizvode po nazivu. | `GET /api/products/search?title=Product` |
| `/api/products/categories/{category}` | GET | Filtrira proizvode po kategoriji i cijeni. | `GET /api/products/categories/electronics?minPrice=50&maxPrice=500` |

**Primjer zahtjeva:**
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
```

```http
GET /api/products/1

{
    "title": "Product 1",
    "description": "Detailed description of the product...",
    "thumbnail": "http://example.com/image1.jpg",
    "price": 99.99
}
```

```http
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
```

```http
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
