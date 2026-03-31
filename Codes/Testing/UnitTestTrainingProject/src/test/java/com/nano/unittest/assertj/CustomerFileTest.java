package com.nano.unittest.assertj;

import javafx.application.Application;
import org.junit.Test;

import com.nano.unittest.customer.exception.MailServerUnavailableException;

import java.io.File;
import static org.assertj.core.api.Assertions.*;

public class CustomerFileTest {
	@Test
    public void testFiles() throws Exception {

        File file = new File("C://Users//Nano//eclipse-workspace//UnitTestTrainingProject//resources//test.txt");

        assertThat(file)
                .exists()
                .canRead()
                .canWrite()
                .hasExtension("txt")
                .hasName("test.txt");

        assertThat(contentOf(file))
                .startsWith("Lorem");

    }

    @Test
    public void testException() throws Exception {
        Exception exception= new MailServerUnavailableException("this is a test");
        assertThat(exception)      
                .hasMessage("this is a test")
                .isInstanceOf(MailServerUnavailableException.class)
                .hasMessageContaining("is a");

    }
}
