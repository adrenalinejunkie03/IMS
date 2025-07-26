truncate table purchaseInvoice

DELETE FROM purchaseInvoice
DBCC CHECKIDENT ('purchaseInvoice', RESEED,0)


DELETE FROM purchaseInvoiceDetails
DBCC CHECKIDENT ('purchaseInvoiceDetails', RESEED,0)
