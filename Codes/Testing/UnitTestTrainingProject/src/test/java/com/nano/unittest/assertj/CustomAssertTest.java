package com.nano.unittest.assertj;

import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;
import org.mockito.Mockito; 

import static org.assertj.core.api.Assertions.*;

public class CustomAssertTest {
	private CustomerRepository customerRepository;
    private NotificationService notificationService;
    private CustomerService customerService;

    public static final String USERNAME ="sng";
    public static final String EMAIL ="sng@gmail.com";

    @Before
    public void setUp() throws Exception {
        customerService = new CustomerService();
        customerRepository = Mockito.mock(CustomerRepository.class);
        notificationService = Mockito.mock(NotificationService.class);

        customerService.setCustomerRepository(customerRepository);
        customerService.setNotificationService(notificationService); 
    }

    @Test
    public void testCustomAssertJunit() throws Exception {
        Customer customer=customerService.handleNewCustomer(USERNAME,EMAIL);

        Mockito.verify(customerRepository).save(Mockito.any(Customer.class));
        Mockito.verify(notificationService).sendWelcomeNotification(USERNAME,EMAIL);
        Assert.assertEquals(2,customer.getGifts().size());
        Assert.assertNotNull(customer.getGifts());
        Assert.assertEquals("welcome1",customer.getGifts().get(0).getName());
        Assert.assertEquals("welcome2",customer.getGifts().get(1).getName());

    }

    @Test
    public void testCustomAssert() throws Exception {
        Customer customer=customerService.handleNewCustomer(USERNAME,EMAIL);

        assertThatCustomer(customer)
                .isSaved()
                .hasReceivedWelcomeNotification()
                .hasGifts(2)
                .hasGiftWithName("welcome1")
                .hasGiftWithName("welcome1"); 
    }

    private CustomerAssert assertThatCustomer(Customer customer){
        return new CustomerAssert(customer,CustomerAssert.class,customerRepository,notificationService);
    }
}
