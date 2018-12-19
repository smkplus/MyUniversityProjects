
package Shopping;

import java.sql.*;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;

import javax.swing.DefaultListModel;
import javax.swing.JList;
import javax.swing.JTable;
import javax.swing.table.DefaultTableModel;
import javax.swing.table.TableModel;

public class Market {
    
    DefaultListModel<String> SearchResult;
    DefaultTableModel ProductsTableModel = new DefaultTableModel();


    Statement st;

    public Market(){

    SearchResult = new DefaultListModel<String>();
                        ProductsTableModel.addColumn("نام محصول");
                    ProductsTableModel.addColumn("قیمت محصول");
    LoadDataBase();
    }
    
    
    public void AddItem(String name,int value){
        
        
        try {
          String command = "INSERT INTO `products` (`ProductName`, `UnitPrice`) VALUES ("+"\""+name+"\""+","+"\"" +value+"\""+")";

            st.executeUpdate(command);
            ProductsTableModel.addRow(new Object[]{name,value});
            LoadDataBase();
        } catch (Exception ex) {
            System.err.println(ex.getMessage());
            
        }

    }
    
    public void SearchItem(String name){
                SearchResult.clear();
             try {
          String command = "SELECT * FROM products WHERE ProductName LIKE"  + "'%" +name+ "%'";

            st.executeQuery(command);
            ResultSet rs = st.getResultSet();
                   while (rs.next()) {
        System.out.println(rs.getString(1) + " " + rs.getString(2));
        SearchResult.addElement(rs.getString(1) + " " + rs.getString(2));
       }
        } catch (Exception ex) {
            System.err.println(ex.getMessage());
            
        }   
    }
    
    public void LoadDataBase(){
       int rowCount = ProductsTableModel.getRowCount();
//Remove rows one by one from the end of the table
for (int i = rowCount - 1; i >= 0; i--) {
    ProductsTableModel.removeRow(i);
} 
        try {
            Class.forName("com.mysql.jdbc.Driver").newInstance();
            Connection con = DriverManager.getConnection("jdbc:mysql:///market?useUnicode=true&characterEncoding=utf-8", "root", "");
             st = con.createStatement();

            
            String command = "SELECT * FROM `products`";
            
            st.executeQuery(command);
            ResultSet rs = st.getResultSet();
            
            rs.last();
            int size = rs.getRow();
            rs.beforeFirst();
            if (size>0)
            {

                System.out.println("وجود دارد"+" "+size);
                   while (rs.next()) {
                    String result = rs.getString(1) + "  |  " + rs.getString(2);
                    System.out.println(result);
                   // products.addElement(result);
                   ProductsTableModel.addRow(new Object[]{rs.getString(1),rs.getString(2)});

                   }
            
            }
            else{
                System.out.println("وجود ندارد");
            }
           
            
        } catch (Exception ex) {
            System.err.println(ex.getMessage());
            
        }
    }
    
    public static void main(String[] args) {
        new Home().setVisible(true);


        
        
    }

    
}
