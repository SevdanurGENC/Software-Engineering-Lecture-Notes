package com.nano.unittest.assertj;

import org.assertj.core.api.AbstractAssert;
import static org.assertj.core.api.Assertions.*;
import org.junit.Assert;
import org.mockito.Mockito;
import com.nano.unittest.assertj.CustomAssertTest;
import com.nano.unittest.assertj.Customer;
import com.nano.unittest.assertj.CustomerRepository;
import com.nano.unittest.assertj.NotificationService;

public class CustomerAssert extends AbstractAssert<CustomerAssert,Customer>{
    CustomerRepository customerRepository;
    NotificationService notificationService;
    public CustomerAssert(Customer actual, Class<?> selfType, CustomerRepository customerRepository, NotificationService notificationService) {
        super(actual, selfType);
        this.customerRepository=customerRepository;
        this.notificationService=notificationService;
        isNotNull();
    }

    public CustomerAssert hasGifts(int sizeOfGifts) {
        assertThat(actual.getGifts())
                .isNotNull()
                .hasSize(2);
        return this;
    }

    public CustomerAssert hasGiftWithName(String value) {
        assertThat(actual.getGifts())
                .isNotNull()
                .extracting("name")
                .contains(value);
        return this;
    }

    public CustomerAssert isSaved() {
        Mockito.verify(customerRepository).save(Mockito.any(Customer.class));
        return this;
    }

    public CustomerAssert hasReceivedWelcomeNotification() {
        Mockito.verify(notificationService).sendWelcomeNotification(CustomAssertTest.USERNAME,CustomAssertTest.EMAIL);
        return this;
    }
}
