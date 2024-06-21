# Aspnet-api
Stručni zadatak za .NET developera.

## Endpointovi

| Endpoint | Metoda | Opis | Parametri |
|----------|--------|------|-----------|
| `/api/products` | GET | Vraća listu proizvoda sa slikom, nazivom, cijenom i skraćenim opisom (do 100 znakova). | Nema |
| `/api/products/{id}` | GET | Vraća detalje jednog proizvoda na temelju njegovog ID-a. | `id` (int) - ID proizvoda |
| `/api/products/search` | GET | Pretražuje proizvode po nazivu. | `title` (string) - Tekst za pretraživanje po nazivu proizvoda |
| `/api/products/categories/{category}` | GET | Filtrira proizvode po kategoriji i cijeni. | `category` (string) - Kategorija proizvoda, `minPrice` (float) - Minimalna cijena, `maxPrice` (float) - Maksimalna cijena |
