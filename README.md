StronglyTypedViews
==================

Avoid the error "The model item passed into the dictionary is of type ‘X’ but this dictionary requires a model item of type ‘Y‘".

The template generates truly strongly typed views to use in yout controllers.

ex:

        public virtual ViewResult GetNumber()
        {
            return new StronglyTypedViews.Home()._Partial(16);
        }
