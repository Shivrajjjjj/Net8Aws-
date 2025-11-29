---
```
# Net8Aws – .NET 8 + AWS CI/CD Pipeline (ECR + ECS Fargate)

##  Run Locally
```

dotnet run --project src/Net8Aws

```
# run frontend 
```

cd frontend
npx serve

```

##  Docker Build & Run
```

docker build -t net8aws .
docker run -p 8080:80 net8aws

```

##  AWS Deployment Flow (CI/CD)
1. Developer pushes code → GitHub / CodeCommit  
2. **AWS CodePipeline** triggers automatically  
3. **CodeBuild**:  
   - Restores .NET packages  
   - Builds Docker image  
   - Pushes updated image to **Amazon ECR**  
4. **CodePipeline → ECS Deploy stage** updates ECS service  
5. **ECS Fargate** launches the new container version  
6. Application becomes live with zero downtime ✔

##  AWS Services Used
- **Amazon ECR** – Docker image repository  
- **AWS CodeBuild** – Build + Docker image creation  
- **AWS CodePipeline** – Full CI/CD automation  
- **Amazon ECS Fargate** – Serverless container hosting  
- **CloudFormation** – Infrastructure as code (optional)

