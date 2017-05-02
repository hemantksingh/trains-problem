.PHONY: build test run

build:
	cd src && dotnet restore

test:
	cd test && \
	dotnet restore && \
	dotnet test

run:
	cd src && \
	dotnet restore && \
	dotnet run