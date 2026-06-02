# Geavanceerde .NET Core Cloud Integratie: Real-time Data Processing Pipeline

Ontwikkel een schaalbare en efficiënte real-time data processing pipeline met behulp van .NET Core en Azure cloud services. De pipeline moet inkomende data van een gesimuleerde bron (bijvoorbeeld een Azure Event Hub of een gesimuleerde stream) kunnen verwerken, transformeren en opslaan in een Azure SQL Database.  De focus ligt op het implementeren van robuuste foutafhandeling, optimalisatie van de dataverwerking en het demonstreren van effectieve technologie-integratie.

**Specifieke vereisten:**

1.  **Data Bron Simulatie:** Creëer een eenvoudige .NET Core applicatie die gesimuleerde data (bijvoorbeeld JSON-objecten met sensordata) genereert en deze naar een gesimuleerde data stream stuurt. Gebruik hiervoor een geschikte .NET Core library.
2.  **Data Processing Service:** Ontwikkel een .NET Core service die de data uit de stream consumeert. Deze service moet de volgende transformaties uitvoeren:
    *   Validatie van inkomende data.
    *   Aggregatie van data over een bepaald tijdsinterval (bijvoorbeeld gemiddelde temperatuur per minuut).
    *   Eventuele filtering van onnodige datapunten.
3.  **Azure Integratie:**
    *   Gebruik Azure Functions of Azure WebJobs voor de data processing service om schaalbaarheid te garanderen.
    *   Integreer met Azure SQL Database voor het opslaan van de getransformeerde data.
    *   Implementeer logging en monitoring met behulp van Azure Application Insights.
4.  **Foutafhandeling en Resiliency:** Implementeer strategieën voor foutafhandeling, zoals retries voor mislukte database-operaties en een mechanisme voor het afhandelen van 'dead-lettered' berichten (data die niet verwerkt kon worden).
5.  **Code Kwaliteit en Structuur:** Zorg voor een duidelijke, modulaire code structuur. Gebruik dependency injection en volg best practices voor .NET Core ontwikkeling.
6.  **Documentatie:** Lever een duidelijke README.md in de GitHub repository die uitlegt hoe de applicatie te bouwen, te deployen (conceptueel) en te testen. Beschrijf de architectuurkeuzes en de gebruikte Azure services.

**Extra Uitdaging (Optioneel):**

*   Implementeer een mechanisme voor het dynamisch aanpassen van de aggregatie-interval of filtercriteria zonder de applicatie opnieuw te hoeven deployen (bijvoorbeeld via Azure App Configuration).
*   Gebruik .NET Core's `Span<T>` en `Memory<T>` voor geoptimaliseerde geheugenbeheer tijdens de dataverwerking.
*   Integreer met Azure Service Bus voor een meer robuuste berichtafhandeling.

**Beoordelingscriteria:**

*   Correctheid en functionaliteit van de data pipeline.
*   Schaalbaarheid en efficiëntie van de oplossing.
*   Kwaliteit van de code (leesbaarheid, onderhoudbaarheid, testbaarheid).
*   Effectiviteit van de foutafhandeling en resiliency.
*   Succesvolle integratie met Azure services.
*   Duidelijkheid en volledigheid van de documentatie.

## Opdracht

Implementeer de gevraagde functionaliteit.