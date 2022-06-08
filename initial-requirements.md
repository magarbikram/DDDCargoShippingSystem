Cargo Shipping Systems

We are developing new software for cargo shipping company. The initial requirements are threee basic functions. 

1. Track key handling of customer cargo
2. Book cargo in advance
3. Send invoices to customers automatically when the cargo reaches some point in its handling.

Domain Model: https://miro.com/app/board/uXjVOYt1Qi4=/?moveToWidget=3458764526934916352&cot=14

**Isolating the Domain: Introducing the Applications**

To prevent domain responsibilities from being mixed with those of other parts of the system, let's apply Layered Architecture

Without going into deep analysis, we can identify three user level application functions, which we can assign to 
three application layer classes.
1. A **Tracking Query** that can access past and present handling of a particular Cargo
2. A **Booking Application** that allows a new Cargo to be registered and prepares the system for it
3. An **Incident Logging Application** that can record each handling of the Cargo

These application classes are coordinators. They should not work out the answers to the questions they ask. 
That is the domain layer's Job