.PHONY: build test run

build:
	cd src && dotnet restore

test:
	cd test && dotnet test

run:
	cd src && dotnet run