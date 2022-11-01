# Library Book Service - Technical Test

## Introduction

Welcome to the Trainline 2nd Round Interview - Tech Test. 

This will be a 90 minute pair programming style exercise in which you will attempt to solve the scenario below, but, <u>before you do here are a few guidelines to help guide you and ensure you can do your best on the day, so please read them carefully</u> 🙂

1. The test is designed to be open ended, by which we mean you are free to tackle it in any way you see fit.
1. We ask that you tackle this test as you would any code you were writing for a production system - Example: best practices vs hacking.
1. The purpose of this exercise is not to get to the end, but to show us the process you use to get there. We are trying to assess not only how you code but also the thought process you follow to get to the solution.
1. Traits we love to see from candidates include, but are not limited to, the following: 
    - Good programming practices
    - Good use of patterns
    - Thinking about testability of code
    - Good api design
    - Use of modern framework/language features
1. This **is not a closed book** test, you are free to Google search or Stack Overflow any answers you need.
1. You may use any OSS packages/nuget code you wish
1. We would prefer you not to prepare any code ahead of time, because we want to pair with you and see how you think/solve problems, but we appreciate that this can be stressful so if you wish to spend time outside the interview to prep then please do so; but please remember we don't expect it because your time is valuable.
1. You are free to use any IDE you wish, and if you would like a blank solution to bootstrap your work, [you can find one here to download/clone](https://github.com/trainlinerecruitment/starter-solution-csharp)
1. Have fun, we want you to enjoy this experience, your interviewers will be on hand to help you, use them like a coding buddy.

Good luck! 😃

---

## Scenario

A library is wanting to build a new API for book management. The API we are building is to allow the library to store details about unique books that the library contains, it will not contain multiple entries for the same book (here 'same book' means duplicated Id).

A book is a very simple data structure that contains the following fields:
- Id
- Title
- Author
- Date of publication

### Functionality Required

This API needs to follow the standard RESTful pattern and allow for the following operations to take place:

- Add a new book to the library
- Remove an existing book from the library using its `Id`
- Update an existing book in the library using its `Id`
- Get a book by its `Id`
- Get all books in the Library

### Business Rules
- `Book` `Id`'s stored in our library must be unique. The format/structure of this `Id` is completely up to you.
- All fields on a `Book` cannot be `null` or `empty`
- All `Date of publication`s must be in the past
- `Book` `Author`s must have at least one name 
   - _Example: `Prince` or `Prince Edward` or `Prince Edward VII`_
- If a request is invalid, all fields that are invalid should be reported back to the requestor.

For now, while the application is being tested, the library only wants to store their book records in memory, but, in future they will likely want to swap memory storage for another more permanent storage solution.

## Your Task

Please implement a RESTful API service that will enable the above scenarios.
