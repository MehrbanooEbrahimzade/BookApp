# Book App

## Overview

This project is a sample illustrating the power of parallelism in .NET 7. The Book App lets users explore a collection of books and customize the text display through the "Change Font Size" feature. It dynamically adjusts words per page based on the chosen font size, showcasing the simplicity and effectiveness of parallel processing.

## Apis

1. **Get all Books**
   - Endpoint: `GET /Books`
   - Initializes all books and returns the list of books with pages.

2. **Get Page**
   - Endpoint: `GET /Books/{bookId}/{pageNumber}`
   - Retrieves a specific page of the book based on the provided book ID and page number.

3. **Change Font Size**
   - Endpoint: `PUT /Books/{bookId}/{fontSize}`
   - Changes the font size of the book and returns the book with suitable words per page.

## Contributions Welcome

Feel free to contribute! If you spot issues or have suggestions, pull requests are warmly welcomed.
Your input helps make this project better. Happy coding!
