# Product Middleware REST API

Ovaj projekt implementira middleware REST API za dohvat proizvoda iz različitih izvora. Trenutno podržava dohvat proizvoda iz REST API izvora. API omogućava napredno filtriranje proizvoda i pretragu po nazivu.

## Tehnologije

- .NET 8
- ASP.NET Web API
- Entity Framework

## Funkcionalnosti

- **Dohvat liste proizvoda**: Vraća listu proizvoda sa slikom, nazivom, cijenom i skraćenim opisom (do 100 znakova)
- **Dohvat detalja proizvoda**: Vraća detalje pojedinog proizvoda
- **Filtriranje proizvoda**: Omogućava filtriranje proizvoda po kategoriji i cijeni
- **Pretraga proizvoda po nazivu**: Pretražuje proizvode po unesenom tekstu

### "Nice to have" funkcionalnosti

- Keširanje rezultata pretrage i filtriranja
- Logiranje (Info, Warning, Error)

## Struktura Projekta

Projekt je strukturiran prema preporučenim dobrim praksama i konvencijama:

- `Controllers` - Sadrži API kontrolere
- `Models` - Sadrži modele podataka i DTO-e
- `Services` - Sadrži poslovnu logiku
- `Intefaces` - Sadrži sučelja
- `Repositories` - Sadrži kod za pristup podacima

## API Dokumentacija

### Endpointi


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
