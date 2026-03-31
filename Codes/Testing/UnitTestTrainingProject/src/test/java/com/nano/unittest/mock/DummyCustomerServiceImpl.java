package com.nano.unittest.mock;

public class DummyCustomerServiceImpl implements DummyCustomerService {
     
    public void addCustomer(String customerName) {
        System.out.println("addCustomer("+customerName+")");
    }

     
    public void removeCustomer(String customerName) {
        System.out.println("removeCustomer("+customerName+")");
    }

     public void updateCustomer(String customerName) {
        System.out.println("updateCustomer("+customerName+")");
    }

     
    public String getCustomer(String customerName) {
        return "getCustomer("+customerName+")";
    }
}
