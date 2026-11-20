# Part 02 — answers

---

## Reports

- What was the problem?
   The three report exporters had duplicated code for loading, validating, and saving the data
   Only the formatting was different.

- What did you change?
   Created an abstract ReportExporter class that contains the common workflow 
   and moved the different formatting logic to the Format() method in each report exporter.

- Why did you choose that approach?
   I used the Template Method Pattern to keep the common steps in one place
   while allowing each report type to implement its own formatting.

- Why is an abstract class a better fit than an interface?

  An abstract class is a better fit because the report exporters share common code and a common workflow.
  The base class can contain the shared  Load() , Validate() ,  Save() , and  Export() methods
  Each report type only needs to implement the different  Format() method
  An interface would define the contract  but it would not be the best place to share this common implementation and workflow.
---

## Enrollment

- What was the problem?
  The client had to directly call multiple services and know the order of the enrollment steps.
- 
- What did you change?
  Created an EnrollmentFacade that coordinates the payment seat reservation, invoice creation, and email notification.

- Why did you choose that approach?
   I used the Facade Pattern to provide a simple entry point for the enrollment process while keeping the existing services unchanged