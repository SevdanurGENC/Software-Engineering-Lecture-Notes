package com.nano.unittest.mock.Annotation;
import org.junit.Before;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.mockito.InjectMocks;
import org.mockito.Mock;
import org.mockito.Mockito;
import org.mockito.Spy;
import org.mockito.runners.MockitoJUnitRunner;

import com.nano.unittest.assertj.CustomerRepository;
import com.nano.unittest.assertj.CustomerService;
import com.nano.unittest.assertj.NotificationService;
import com.nano.unittest.mock.DummyCustomerServiceImpl;

@RunWith(MockitoJUnitRunner.class)
public class AnnotationSpyTest {

   // @Spy
    //private DummyCustomerServiceImpl service;
	
    @InjectMocks
    private CustomerService customerService;
    @Mock
    private CustomerRepository customerRepository;
    @Mock
    private NotificationService notificationService;

    //Aşağıdaki yerine @Mock Annotationını ekledik yukarıya class başınada RunWith Annotationını ekledik . 
 
//    @Before
//    public void setUp() throws Exception {
//        customerService = new CustomerService();
////        customerRepository = Mockito.mock(CustomerRepository.class);
////        notificationService = Mockito.mock(NotificationService.class);
//        customerService.setCustomerRepository(customerRepository);
//        customerService.setNotificationService(notificationService);
//    }

    @Test
    public void testAnotation() throws Exception {
    	customerService.handleNewCustomer("name", "email");
    	//service.addCustomer("istanbul"); 
    }
}
