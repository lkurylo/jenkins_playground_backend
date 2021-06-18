
pipeline {
  agent any
  options { timestamps () }
  // stages and rest of pipeline.

  stages(){

      stage('build'){
        steps{
            catchError {
                sh 'dotnet build --no-incremental'
                sh 'dotnet test --test-adapter-path:. --logger:xunit --collect:"XPlat Code Coverage" --results-directory:"tests/TestResults"'
                sh '$HOME/.dotnet/tools/reportgenerator "-reports:tests/TestResults/*/coverage.cobertura.xml" "-targetdir:tests/TestResults/CoverageReport" -reporttypes:Html'
            }
        }
      }

      stage('post_build_actions'){
          steps{
              publishHTML([allowMissing: false, alwaysLinkToLastBuild: false, keepAll: false, reportDir: 'tests/TestResults/CoverageReport', reportFiles: 'index.html', reportName: 'HTML Report', reportTitles: ''])
              xunit([xUnitDotNet(excludesPattern: '', pattern: 'tests/TestResults/TestResults.xml', stopProcessingIfError: true)])

          }
      }
  }
}