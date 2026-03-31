package com.nano.unittest.mock;
import org.junit.Test;
import org.mockito.InOrder;

import static org.mockito.Mockito.*;
public class BehaviourTest {
	@Test
    public void testBehaviour() throws Exception {

        DummyCustomerService customerService=mock(DummyCustomerService.class);

        customerService.addCustomer("Istanbul");
        customerService.addCustomer("ankara");

        //bu servisin bu customerlar ile cagrilmasi gerektigi kontrol ediliyor
        verify(customerService).addCustomer("Istanbul");
        verify(customerService).addCustomer("ankara");

    }

    @Test
    public void testMethodKacKereCagirildi() throws Exception {

        DummyCustomerService customerService=mock(DummyCustomerService.class);

        customerService.addCustomer("Istanbul");
        customerService.addCustomer("Istanbul");
        customerService.addCustomer("ankara");
        customerService.addCustomer("Istanbul");


        //bu servisin bu customerlar ile kac kere cagirilmasi gerektigini kontrol eder.
        verify(customerService,times(3)).addCustomer("Istanbul");
        verify(customerService,times(1)).addCustomer("ankara");
        //yazmasakta default 1 davranisi 1 kez olarak kontrol eder.

        //removeCustomer hic bir zaman cagirilmamistir, parametre fark etmez
        verify(customerService,never()).removeCustomer(anyString());

        //izmir kullanicisi hic eklenmedi
        verify(customerService,never()).addCustomer("izmir");

        //en az iki kere cagirildi
        verify(customerService,atLeast(2)).addCustomer("Istanbul");
    }

    @Test
    public void testSirasiniKontrolEt() throws Exception {
    	
        DummyCustomerService customerService=mock(DummyCustomerService.class);

        //verildigi sirada cagirilsin
        customerService.addCustomer("istanbul");
        customerService.addCustomer("ankara");
        customerService.updateCustomer("izmir");

        InOrder inOrder = inOrder(customerService);//istedigimiz kadar mock nesnesi verebiliriz

        inOrder.verify(customerService).addCustomer("istanbul"); //1
        inOrder.verify(customerService).addCustomer("ankara");   //2
        inOrder.verify(customerService).updateCustomer("izmir"); //3

    }


    @Test
    public void testBaskaKontrolYok() throws Exception {

        DummyCustomerService customerService=mock(DummyCustomerService.class);
        DummyCustomerService customerService2=mock(DummyCustomerService.class);

        customerService.addCustomer("Istanbul");
        customerService.addCustomer("ankara");
        //customerService.addCustomer("izmir");  // hata verifyNoMoreInteractions
        //customerService2.addCustomer("ankara");  // hata verifyZeroInteractions

        //bu servisin bu customerlar ile çağrılması gerektiği kontrol ediliyor
        verify(customerService).addCustomer("Istanbul");
        verify(customerService).addCustomer("ankara");


        verifyNoMoreInteractions(customerService);//yukarıda üzerinde kontroller yapılanlar dışında başka çağrı olmasın

        verifyZeroInteractions(customerService2);//hiç bir şekilde çağrılma olmasın bu nesne için

    }
}
