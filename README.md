# Room Availability Service - Technical Test

If you are here it's probably because you applied for a Software Engineering role at Trainline. This repo describes the problem statement you will be tackling during the actual interview. 

<u>**Please ensure you read the notes below before start thinking about the scenario**</u>

Good luck! :)

## Notes

- You may utilise any libraries and frameworks you wish to achieve the business scenario above. 
- Please ensure though that you don't prepare any code in advance, we would like to see you work on this exercise from scratch during the interview call :)
- A blank Visual Studio solution is [provided here in the repo](https://github.com/trainlinerecruitment/library/tree/main/solution) if you would like to use it. It is completely optional to use this; and you can start from scratch on the day if you prefer.
- We would like you approach this problem with a "Production Mindset"; think about how you would solve this problem as you would any production code/system.

---

## Scenario

We have been tasked with implementing a room booking/availability service as a simple RESTful API. A rooms availability is obtained by calling an external service, which for the purposes of this exercise will be emulated by making HTTP requests to a file accessible on GitHub.

An example `room availability response` consists of a json object containing daily availability attributes; each consisting of 48 characters (`1` or `0`).

 Example:
 ```json
 {
   "availability": {
       "monday": "000000000011111111110011100010100011101010110100",
       "tuesday": "000001100111100011110011111110100011101111110100",
       "wednesday": "000000000011111111110000000000000000001010000100",
       "thursday": "000000000011100111110011100011111111101010110100",
       "friday": "000000000011100101110010011111101110011111101100",
     }
 }
 ```

 This file structure shows:
 - The first character for a days schedule indicates `00:00` or "midnight"
 - Each character represents a 30 min time slot of the day
 - The last character for a days schedule indicates `23:30`
 - If a character is `0` the room is free for that 30 min window
 - If a character is `1` the room is booked for that 30 min window
 - So for the example room above `Monday` the room is first booked at `05:00` until `10:00`
 - There is no entry for Saturday or Sunday as these are not valid days to use meeting rooms.

---

## Your Task

 Create an API that allows users to query the upstream booking service. Your API needs to implement the following API actions:
 - Provide a mechanism to retrieve the availability for a room for a given `day of the week`. 
 - The `day of the week` can be specified in numerical format (`1 == Monday, 2 == Tuesday` etc.) or in string format (`Monday, Tuesday` etc.)
 - Provide a mechanism to retrieve the availability for a room for all days of the week.
 - Provide a mechanism to retrieve the availability for a room for a specific `day of the week`.
 - Provide a mechanism to check if a room is free on a specific `day of the week` and `time of day` for a specified `duration in minutes`.
 - If a request is made for an invalid day or time then an appropriate response should be returned.
 - We have identified that the real availability service has stability issues, when making external calls we need to ensure we have resilience implemented.
 - When returning your response we require a human readable format. This format is up to you, but an example is shown below:
  ```json
  {
      "room": "xyz",
      "schedule": [
          {
            "day": "monday",
            "availability": {
                "00:00": false,
                "00:30": false,
                "01:00": false
                ...
            }
          },
          {
              "day": "tuesday",
              "availability": {
                "00:00": true,
                "00:30": true,
                "01:00": true
                ...
            }
          }
      ]
  }
  ```

## Notes

 For the purpose of this exercise:
 - You can [utilize the example room availability file located here](https://raw.githubusercontent.com/trainlinerecruitment/room-booking/main/availability.json) for all room availabilities; hosted on GitHub.
   - For now we are using a dummy file on GitHub, but eventually we must be able to easily swap the uri to a real endpoint.
 - Your api design needs to enable querying availability per `room name` but for this exercise assume all rooms will use/have the same availability.
 - The physical date is not important, you can assume every week the schedule is the same for all rooms, only the `day of the week` is required for requests.
 - When showing the room availability in responses, it should be rendered in 30 min increments.

 Please implement a RESTful API service that will enable all the above scenarios.
