# Part 01 — answers

---

## ShippingCostCalculator

- What was the problem?
  The switch contained the calculation logic for all carriers
  so adding a new carrier required modifying the class.
 
- What did you change?
  Created IShippingCostCalculator and separate classes for each carrier
  so ShippingCostCalculator depends on the interface instead of the switch.
---

## OrderProcessor

- What was the problem?
  OrderProcessor  directly created concrete classes causing tight coupling.

- What did you change?
  Created interfaces for the repository and email sender 
  then injected them into OrderProcessor through the constructor.

---

## Notifications

- What was the problem?
  The notification classes used inheritance for every combination of channel and behavior
  causing duplicated code and too many classes.

- What did you change?
   Used composition to separate notification channels from behaviors such as urgent and scheduled notifications
   so they can be combined without creating a new class for each combination.

---

## Proof

- New carrier file(s):   UpsCarrier
- New notification channel file(s):
- Existing classes left unchanged? (yes/no): yes
