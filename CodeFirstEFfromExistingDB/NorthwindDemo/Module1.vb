Imports Northwind.DataAccessLayer

Module Module1

    Sub Main()

        Using dbContext As New NorthwindDbContext()

            Dim categories = dbContext.Categories

            For Each category In categories
                Console.WriteLine(category.CategoryId & " " & category.CategoryName)
            Next

            Console.WriteLine()

            Dim customerHistories = dbContext.CustOrderHist("ALFKI")

            For Each customerHistory In customerHistories
                Console.WriteLine($"{customerHistory.Total,2} {customerHistory.ProductName}")
            Next


            Dim orderDetail = dbContext.OrderDetails.First()
            Console.WriteLine(orderDetail.Product.ProductName)

            Console.WriteLine()

            PrintDbContextSaveChangesCount(dbContext)
            dbContext.SaveChanges()
            dbContext.SaveChanges()
            PrintDbContextSaveChangesCount(dbContext)

            PrintNewTables(dbContext)

            ' Update Table: NewTable
            Dim efNewTables = dbContext.NewTables

            For Each efNewTable In efNewTables
                efNewTable.NewField = DateTime.Now
            Next

            ' save changes
            dbContext.SaveChanges()

            PrintNewTables(dbContext)

        End Using

        Console.WriteLine("Press any key to exit....")
        Console.ReadKey()
    End Sub


    Private Sub PrintDbContextSaveChangesCount(dbContext As NorthwindDbContext)
        Console.WriteLine($"DbContext SavechangesCount: {dbContext.GetSaveChangesCount()}")
    End Sub

    Private Sub PrintNewTables(dbContext As NorthwindDbContext)
        Dim newTables = dbContext.Database.SqlQuery(Of NewTable)("select * from NewTable")

        For Each newTable In newTables
            Console.WriteLine($"id: {newTable.Id}   name: {newTable.Name}   desc: {newTable.Desc}   datetime: {newTable.NewField}")
        Next

    End Sub
End Module
