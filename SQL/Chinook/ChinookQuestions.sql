--For each of the following exercises, provide the appropriate query.
--Keep your successful queries in a chinook-queries.sql file.

--Provide a query showing Customers (just their full names, customer ID and country) who are not in the US.
SELECT CustomerId, FirstName, LastName, Country FROM Customer WHERE Country != 'USA';

--Provide a query only showing the Customers from Brazil.
SELECT CustomerId, FirstName, LastName, Country FROM Customer WHERE Country = 'Brazil';

--Provide a query showing the Invoices of customers who are from Brazil. The resultant table should show the customer's full name, 
--Invoice ID, Date of the invoice and billing country.
SELECT InvoiceId, FirstName, LastName, InvoiceDate, BillingCountry 
FROM Invoice, Customer 
WHERE Invoice.CustomerId = Customer.CustomerId AND Customer.Country = 'Brazil';

--Provide a query showing only the Employees who are Sales Agents.
SELECT EmployeeId, LastName, FirstName FROM Employee WHERE Title = 'Sales Support Agent';

--Provide a query showing a unique list of billing countries from the Invoice table.
SELECT DISTINCT BillingCountry FROM Invoice;

--Provide a query that shows the invoices associated with each sales agent. The resultant table should include the Sales Agent's full name.
SELECT Invoice.InvoiceId, InvoiceDate, Employee.FirstName + Employee.LastName AS SalesAgents, Employee.Title FROM Invoice, Employee, Customer 
WHERE Invoice.CustomerId = Customer.CustomerId AND Employee.EmployeeId = Customer.SupportRepId AND Employee.Title = 'Sales Support Agent';

SELECT Invoice.*, Employee.FirstName, Employee.LastName, Customer.SupportRepId
FROM Invoice, Employee
INNER JOIN Customer
ON Employee.EmployeeId = Customer.SupportRepId


--Provide a query that shows the Invoice Total, Customer name, Country and Sale Agent name for all invoices and customers.
SELECT
    Total AS InvoiceTotal,
    Customer.FirstName + ' ' + Customer.LastName AS CustomerName,
    Customer.Country AS CustomerCountry,
    Employee.FirstName + ' ' + Employee.LastName AS SalesAgents
FROM Employee
INNER JOIN Customer ON Employee.EmployeeId=Customer.SupportRepId
INNER JOIN Invoice ON Customer.CustomerId=Invoice.CustomerId
WHERE Title='Sales Support Agent';


--How many Invoices were there in 2009 and 2011? What are the respective total sales for each of those years?
SELECT COUNT(InvoiceDate) AS TotalInvoices, SUM(total) AS TotalSales
FROM Invoice
WHERE YEAR(InvoiceDate)=2009 OR YEAR(InvoiceDate)=2011;

SELECT COUNT(InvoiceDate) AS TotalInvoices2011, SUM(total) AS TotalSales2011
FROM Invoice
WHERE YEAR(InvoiceDate)=2009;
SELECT COUNT(InvoiceDate) AS TotalInvoices2011, SUM(total) AS TotalSales2011
FROM Invoice
WHERE YEAR(InvoiceDate)=2011;


--Looking at the InvoiceLine table, provide a query that COUNTs the number of line items for Invoice ID 37.

--Looking at the InvoiceLine table, provide a query that COUNTs the number of line items for each Invoice. HINT: GROUP BY

--Provide a query that includes the track name with each invoice line item.

--Provide a query that includes the purchased track name AND artist name with each invoice line item.

--Provide a query that shows the # of invoices per country. HINT: GROUP BY

--Provide a query that shows the total number of tracks in each playlist. The Playlist name should be included on the resultant table.

--Provide a query that shows all the Tracks, but displays no IDs. The resultant table should include the Album name, Media type and Genre.

--Provide a query that shows all Invoices but includes the # of invoice line items.

--Provide a query that shows total sales made by each sales agent.

--Which sales agent made the most in sales in 2009?

--Which sales agent made the most in sales in 2010?

--Which sales agent made the most in sales over all?

--Provide a query that shows the # of customers assigned to each sales agent.

--Provide a query that shows the total sales per country. Which country's customers spent the most?

--Provide a query that shows the most purchased track of 2013.

--Provide a query that shows the top 5 most purchased tracks over all.

--Provide a query that shows the top 3 best selling artists.

--Provide a query that shows the most purchased Media Type.

--Provide a query that shows the number tracks purchased in all invoices that contain more than one genre.
