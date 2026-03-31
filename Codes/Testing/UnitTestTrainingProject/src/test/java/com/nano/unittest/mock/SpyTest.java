package com.nano.unittest.mock;
import org.junit.Test;

import java.util.IllegalFormatCodePointException;

import static org.mockito.Mockito.*;
//gerçek nesneye ihtiyaç duyacağı için burada impl dosyasını oluşturduk service
//yerine göre hem gerçek nesne hemde mock nesnesi olarak kullanılabiliyor.
public class SpyTest {

  @Test
  public void testSpy() throws Exception {
      DummyCustomerService service=spy(new DummyCustomerServiceImpl());

      doNothing().when(service).addCustomer("istanbul");
      //doThrow(new IllegalArgumentException()).when(service).removeCustomer(anyString()); 
      //ne yazarsan yaz hatayı atıcak

//      service.addCustomer("istanbul");
//      service.addCustomer("ankara"); // ankara için bir mock yazılmadığı için gerçek nesneyi çağırır.
//      service.removeCustomer("***");

      doNothing().when(service).removeCustomer("İstanbul1");
      doNothing().when(service).removeCustomer("İstanbul2");
      //doCallRealMethod().when(service).removeCustomer("İstanbul3"); 
      //bu olmasada spy olduğu için gerçek nesneyi çağıracak.

      service.removeCustomer("İstanbul1");
      service.removeCustomer("İstanbul2");
      service.removeCustomer("İstanbul3");

  }
}