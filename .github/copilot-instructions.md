## Repo snapshot

This repository contains several small .NET console sample apps demonstrating C# basics. Key projects:

- `SampleApp/` — a minimal console app with `Program.cs` that prompts for a name.
- `ObjectDemo/` — demonstrates a `BankAccount` class (`BankAccount.cs`) and usage from `Program.cs`.
- `ConsoleApp1/` — another simple console example and a `.csproj` targeting `net9.0`.

All projects target net9.0 and use implicit usings and nullable reference types (see `<TargetFramework>net9.0</TargetFramework>` and `<ImplicitUsings>enable</ImplicitUsings>` in the csproj files).

## Big-picture architecture (what matters to an AI coder)

- This is not a web/service repo — it contains independent console apps. There are no background services, database connections, or dependency-injection containers to learn.
- Each app is self-contained: the relevant code is in the project folder (e.g., `ObjectDemo/BankAccount.cs`, `ObjectDemo/Program.cs`). Treat each folder as an independent runnable target.

## How to build & run (concrete commands)

- Build the whole solution: `dotnet build ConsoleApp1.sln`
- Build a single project: `dotnet build ./ObjectDemo/ObjectDemo.csproj`
- Run a single project: `dotnet run --project ./ObjectDemo/ObjectDemo.csproj`

Notes: dotnet CLI is the canonical workflow; there are no additional build scripts or package managers in this repo.

## Project-specific conventions and patterns

- Namespace matches folder/project name (e.g., `namespace ObjectDemo` in `ObjectDemo/Program.cs`). Keep this convention when adding files.
- Projects use C# top-level program style in some places (`ConsoleApp1/Program.cs`) and classic `Program` class in others—follow the existing style in the target project when editing.
- Nullable reference types are enabled. Be defensive when reading `Console.ReadLine()` (it can return null). Example: `var username = Console.ReadLine() ?? "";` or validate before using.
- Simple POCOs: `ObjectDemo/BankAccount.cs` shows common patterns: private backing fields, public properties, a read-only field, and static helper methods (e.g., `GetMaxBalance`). Prefer similar styles for small domain types.

## Common edit/PR targets for an agent

- Add a new console demo: create a new folder with a `*.csproj` targeting `net9.0` and a `Program.cs` that follows either the top-level or classic `Program` style used in the repo.
- Modify `ObjectDemo/BankAccount.cs`: respect its existing public API (`AccountName`, `AccountNumber`, `GetMaxBalance`) when changing behavior to avoid breaking simple demos.

## Debugging tips

- Use `dotnet run --project <path>` to reproduce console interactions locally.
- Console input may be null (nullable enabled). Wrap or guard `Console.ReadLine()` usages.

## Integration & external dependencies

- There are no external package dependencies shown in the projects; additions should be explicit in the `.csproj` and kept minimal.

## Examples (from this repo)

- Guarding Console.ReadLine():

  var username = Console.ReadLine() ?? "(unknown)";

- Reference to model: `ObjectDemo/Program.cs` constructs a `BankAccount` using object initializer syntax:

  BankAccount custAccount = new BankAccount() { AccountName = "John Smith", AccountNumber = 53211 };

## Do / Don't for AI edits

- Do: Preserve project TargetFramework, ImplicitUsings, and Nullable settings in `.csproj` when adding files.
- Do: Keep namespaces aligned with folder/project names.
- Don't: Assume web frameworks, DI, or tests exist — add them explicitly if the task requires.

## Where to look for examples

- `ObjectDemo/BankAccount.cs` — a small model that shows property/backing-field patterns and static helper usage.
- `ObjectDemo/Program.cs` and `SampleApp/Program.cs` — examples of console input/output patterns used throughout.

---
If anything above is unclear or you'd like this file to include additional examples (unit tests, PR checklist, or preferred code style rules), tell me what to add and I will iterate.
