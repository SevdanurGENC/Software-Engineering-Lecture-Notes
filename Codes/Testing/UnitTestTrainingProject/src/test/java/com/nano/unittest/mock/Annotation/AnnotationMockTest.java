package com.nano.unittest.mock.Annotation;
 
import org.junit.Before;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.mockito.Mock;
import org.mockito.Mockito;
import org.mockito.runners.MockitoJUnitRunner;
import com.nano.unittest.mock.DummyCustomerService;

@RunWith(MockitoJUnitRunner.class)
public class AnnotationMockTest {

    //@InjectMocks ile diğer mocklarbunun içine set edilir.

    @Mock
    private DummyCustomerService service;

    //Aşağıdaki yerine @Mock Annotationını ekledik yukarıya clas başınada RunWith Annotationını ekledik 
    @Before
    public void setUp() throws Exception {
        service= Mockito.mock(DummyCustomerService.class); 
    }

    @Test
    public void testAnotation() throws Exception {
        service.addCustomer("istanbul"); 
    }
}
