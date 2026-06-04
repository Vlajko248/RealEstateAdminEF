# RealEstateAdmin - checklist from project documentation

## 1. Domain model and architecture
- [x] Entities exist in DTO layer: `GradDTO`, `ProjekatDTO`, `KategorijaDTO`, `StrukturaDTO`, `NekretninaDTO`, `CenaDTO`
- [x] Layered architecture is preserved:
  - [x] `RealEstateAdmin.WinForms`
  - [x] `RealEstateAdmin.Business`
  - [x] `RealEstateAdmin.Data`
  - [x] `RealEstateAdmin.DTO`
- [x] Data access is isolated in repository classes
- [x] Business validation is isolated in service classes
- [x] WinForms does not directly access the database

## 2. CRUD coverage by module
- [x] `Grad`
- [x] `Projekat`
- [x] `Kategorija`
- [x] `Struktura`
- [x] `Nekretnina`
- [x] `Cena`

## 3. Documented business rules
- [x] Required-field validation exists across services/forms
- [x] Foreign key selection is validated in forms
- [x] `Nekretnina.Kvadratura > 0`
- [x] `Cena.Iznos > 0`
- [x] `Cena.DatumOd <= Cena.DatumDo`
- [x] `Struktura` must belong to selected `Kategorija`

## 4. UI behavior and usability
- [x] Main shell form exists with navigation
- [x] All modules are reachable from `MainForm`
- [x] Grid views use compact fit-to-values sizing
- [x] Related entity names are shown instead of raw foreign key IDs where applicable
- [x] `NekretninaForm` supports in-memory filtering
- [x] `NekretninaForm` supports project-based browsing
- [x] `NekretninaForm` shows current active price for selected real estate item

## 5. Project/folder alignment
- [x] WinForms forms are grouped under `RealEstateAdmin.WinForms\Forms\`
- [x] DTO classes are grouped under `RealEstateAdmin.DTO\Models\`
- [x] Temporary root compatibility copies were removed

## 6. Remaining recommended improvements
- [ ] Add automated tests for service validation rules
- [ ] Add overlap validation for active price periods if required by business rules
- [ ] Standardize column formatting for amounts, dates, and boolean values in all grids
- [ ] Optionally add a short project README with architecture and module overview

## Notes
- Current solution build is green.
- CRUD modules remain intact.
- Folder-based organization is now the only active structure in the solution.
