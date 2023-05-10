FactoryPizza
prende in input l'ordine con il format "TipoBasePizza;TipoImpasto;extra,extra"

La classe factory è suportata da un insieme di classi che si trovano nel SupportFactory.


La Classe Reader ha come costante il path del mio pc, e ogni volta che istanzio un oggetto di tipo
PizzaOrderReader, lo inizializzo con una stringa che sarebbe il nome del file.
il metodo GetPizzaOrder fatualmente resituisce la stringa che poi FactoryPizza prenderà in imput.

NB: entrambe le classi factory e reader funzionano prese singolarmente, tuttavia quando cerco di
    utilizzare il GetPizzaOrder per la factory mi da dei problemi che non ho avuto tempo di fixare.

