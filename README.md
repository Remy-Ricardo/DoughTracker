# DoughTracker

This repository contains a skeleton Blazor Server project. The full project template could not be generated automatically because the `dotnet` SDK is not installed in this environment. Basic source files have been created manually so the project can be completed later with the .NET CLI.

The starter project has been trimmed down to remove the default example pages. A few useful pages remain including `Index.razor`, `_ViewImports.cshtml`, and an `Error` page so the application still runs. In addition, a simple set of domain models is included to begin modeling the finance tracking functionality:

* `Account` – represents a financial account and current balance
* `Transaction` – records deposits or expenses for an account
* `Category` – groups transactions as income or expense
* `Budget` – tracks planned spending over a period
* `BudgetItem` – assigns amounts to specific categories within a budget

Additional starter pages include a Sign In form (`Pages/SignIn.razor`) and a placeholder Financial Overview page (`Pages/FinancialOverview.razor`). These demonstrate basic navigation that can later be hooked up to real authentication and finance data.

## Available Pages

The project now contains empty pages that will be fleshed out later:

- `Pages/Dashboard.razor` – landing page showing a summary of totals and recent transactions
- `Pages/Transactions.razor` – table of all transactions with filtering options
- `Pages/TransactionForm.razor` – add or edit a single transaction
- `Pages/Reports.razor` – monthly and category reports
- `Pages/Categories.razor` – manage transaction categories
- `Pages/Settings.razor` – user preferences

Reusable components live under `Components/` and have been rebuilt using the [Radzen](https://blazor.radzen.com/) component library:

- `TransactionList.razor`
- `SummaryCard.razor`
- `MonthlyReport.razor`
- `ExpenseChart.razor`
- `ConfirmDialog.razor`
- `CategoryDropdown.razor`
- `DateRangePicker.razor`

The `_Host.cshtml` file includes the Radzen CSS and JavaScript references so the library works when running the app. The project file references the `Radzen.Blazor` package, but the package can't be restored until the .NET SDK is installed.
