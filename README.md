# Library Book Service - Technical Test

If you are here it's probably because you applied for a Software Engineering role at Trainline. This repo describes the problem statement you will be tackling during the actual interview. 

<u>**Please ensure you read the notes below before start thinking about the scenario**</u>

Good luck! 🙂

### Notes

- You may utilise any libraries and frameworks you wish to achieve the business scenario above.
- The purpose of this exercise is NOT to get to the end, but instead it is for you to show us your coding, problem solving and communication skills.
- Please don't prepare any code in advance - we would like to see you work on this exercise from scratch during the interview call 🙂
- Optional "starter solutions" are [provided here for candidates](https://github.com/trainlinerecruitment/starter-solution-csharp) if you would like to clone and use them please do - This is completely optional; and you can start from scratch with `File > New` on the day if you prefer.
- We would like you approach this problem with a **"Production Mindset"**; think about how you would solve this problem as you would any production code/system.

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

Please implement a RESTful API service that will enable the above scenarios.
