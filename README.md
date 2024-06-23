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

- Autentifikacija i autorizacija
- Keširanje rezultata pretrage i filtriranja
- Logiranje (Info, Warning, Error)
- Testovi (Integracijski, Unit)

## Struktura Projekta

Projekt je strukturiran prema preporučenim dobrim praksama i konvencijama:

- `Controllers` - Sadrži API kontrolere
- `Models` - Sadrži modele podataka
- `Services` - Sadrži poslovnu logiku
- `Repositories` - Sadrži kod za pristup podacima
- `DTOs` - Sadrži Data Transfer Objekte
- `Configurations` - Sadrži konfiguracijske postavke

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
