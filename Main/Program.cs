using OwlGenerator;
using VDS.RDF;
using VDS.RDF.Ontology;

string rdfFile = @"/home/rusak//Downloads/Telegram Desktop/2.rdf.rdf";

OntologyGraph graph = new OntologyGraph();
graph.LoadFromFile(rdfFile);

OntologyService service = new OntologyService();
service.AddToScMemory(graph);